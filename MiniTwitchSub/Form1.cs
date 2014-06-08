using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace MiniTwitchSub
{
    public partial class Form1 : Form
    {
        private string authCode;
        private TwitchAPICaller twAPI;
        private List<string> prevNames; 
        public Form1()
        {
            InitializeComponent();
            prevNames = new List<string>();
            startUpChecks();
        }

        private void goToAuthroization()
        {
            string clientId = ClientIdField.Text;
            string redirectURI = RedirectURIField.Text;

            if (String.IsNullOrEmpty(clientId) || String.IsNullOrEmpty(redirectURI))
            {
                MessageBox.Show("Please fill out the \"Client ID\" and \"Redirect URI\" fields.");
                return;
            }

            TwitchBrowser.Navigate("https://api.twitch.tv/kraken/oauth2/authorize?response_type=token&client_id=" + clientId + "&redirect_uri=" + redirectURI + "&scope=channel_subscriptions");
        }

        private void startUpChecks()
        {
            string savedPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.json";
            if (File.Exists(savedPath))
            {
                string content;
                using (StreamReader file = new StreamReader(savedPath))
                {
                    content = file.ReadToEnd();
                }

                SettingsConfig conf;

                try
                {
                    conf = JsonConvert.DeserializeObject<SettingsConfig>(content);
                }
                catch (Exception e)
                {
                    return;
                }

                if (conf != null)
                {
                    ClientIdField.Text = conf.ClientId;
                    RedirectURIField.Text = conf.RedirectURI;
                    ChannelNameField.Text = conf.ChannelName;
                    FileLocationField.Text = conf.FileLocation;
                }
            }
        }

        private void writeConfig()
        {
            string savePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.json";

            using (StreamWriter file = new StreamWriter(savePath))
            {
                file.WriteLine("{");
                file.WriteLine("client: \"" + ClientIdField.Text + "\",");
                file.WriteLine("redirect: \"" + RedirectURIField.Text + "\",");
                file.WriteLine("channel: \"" + ChannelNameField.Text + "\",");
                file.WriteLine("file: \"" + FileLocationField.Text.Replace(@"\", @"\\") + "\",");
                file.WriteLine("}");
            }
        }

        private void AuthorizeButton_Click(object sender, EventArgs e)
        {
            goToAuthroization();
        }

        private void TwitchBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (TwitchBrowser.Url.Host == "localhost")
            {
                if (String.IsNullOrEmpty(authCode))
                {
                    string url = TwitchBrowser.Url.AbsoluteUri;
                    int poundIndex = url.IndexOf('#');
                    int ampIndex = url.IndexOf('&');
                    authCode = url.Substring(poundIndex + 1, ampIndex - (poundIndex + 1));
                    authCode = authCode.Replace("access_token=", "");
                }

                if (String.IsNullOrEmpty(ChannelNameField.Text))
                {
                    MessageBox.Show("You need a channel name!");
                    return;
                }

                twAPI = new TwitchAPICaller(authCode, ChannelNameField.Text);
                AuthorizedLabel.Text = "Authorized";
                AuthorizedLabel.ForeColor = Color.ForestGreen;
                writeConfig();
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (FileLocationDialog.ShowDialog() == DialogResult.OK)
            {
                FileLocationField.Text = FileLocationDialog.FileName;
            }
        }

        private void CaptureLoop()
        {
            List<string> names = twAPI.GetSubscribers();

            if (names.Union(prevNames).Count() != names.Count())
            {
                int subCount = 5;

                try
                {
                    subCount = Convert.ToInt32(SubCountField.Text);
                }
                catch (Exception e)
                {
                    return;
                }

                int skip = names.Count() - subCount;
                if (skip < 0)
                {
                    skip = 0;
                }

                List<string> last = names.Skip(skip).ToList();
                using (StreamWriter file = new StreamWriter(FileLocationField.Text))
                {
                    foreach (string name in last)
                    {
                        file.Write(name + ", ");
                    }
                }
            }

            prevNames = names;
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            if (twAPI == null)
            {
                MessageBox.Show("Please Authorize you Client ID first.");
                return;
            }

            if (String.IsNullOrEmpty(FileLocationField.Text))
            {
                MessageBox.Show("Please select a file location.");
                return;
            }

            SubUpdateTimer.Enabled = !SubUpdateTimer.Enabled;

            if (SubUpdateTimer.Enabled)
            {
                CaptureButton.Text = "Stop Capture";
                CapturingLabel.Text = "Capturing";
                CapturingLabel.ForeColor = Color.ForestGreen;
            }
            else
            {
                CaptureButton.Text = "Begin Capture";
                CapturingLabel.Text = "Not Capturing";
                CapturingLabel.ForeColor = Color.Red;
            }
        }

        private void SubUpdateTimer_Tick(object sender, EventArgs e)
        {
            CaptureLoop();
        }
    }
}
