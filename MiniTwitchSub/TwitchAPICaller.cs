using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace MiniTwitchSub
{
    public class TwitchAPICaller
    {
        private string authCode;
        private string token;
        private RestClient client;
        private string channelName;

        public TwitchAPICaller(string authCode, string channelName)
        {
            this.authCode = authCode;
            this.channelName = channelName;
            client = new RestClient("https://api.twitch.tv/kraken/channels/" + channelName + "/subscription");
            client.AddDefaultHeader("Authorization", "OAuth " + authCode);
        }

        private List<String> getSubscribers()
        {

        }
    }
}
