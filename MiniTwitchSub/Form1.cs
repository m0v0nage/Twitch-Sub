using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTwitchSub
{
    public partial class Form1 : Form
    {
        private string authCode;
        private TwitchAPICaller twAPI;
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Application has been authorized for your channel.");
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

            using (StreamWriter file = new StreamWriter(FileLocationField.Text))
            {
                foreach (string name in names)
                {
                    file.Write(name + ", ");
                }
            }
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

            CaptureButton.Text = SubUpdateTimer.Enabled ? "Capturing..." : "Begin Capture";
        }

        private void SubUpdateTimer_Tick(object sender, EventArgs e)
        {
            CaptureLoop();
        }
    }
}
