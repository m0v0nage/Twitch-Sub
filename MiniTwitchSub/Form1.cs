using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTwitchSub
{
    public partial class Form1 : Form
    {
        private string authToken;
        private TwitchAPICaller twAPI;
        public Form1()
        {
            InitializeComponent();
            twAPI = new TwitchAPICaller();
        }

        private void goToAuthroization()
        {
            string clientId = ClientIdField.Text;
            string redirectURI = RedirectURIField.Text;

            if (String.IsNullOrEmpty(clientId) || String.IsNullOrEmpty(redirectURI))
            {

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
                string url = TwitchBrowser.Url.AbsoluteUri;
                int poundIndex = url.IndexOf('#');
                int ampIndex = url.IndexOf('&');
                string authCode = url.Substring(poundIndex + 1, ampIndex - poundIndex + 1);
            }
        }
    }
}
