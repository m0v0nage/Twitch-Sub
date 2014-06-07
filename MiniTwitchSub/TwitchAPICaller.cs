using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace MiniTwitchSub
{
    public class TwitchAPICaller
    {
        private string authCode;
        private RestClient client;
        private string channelName;
        private readonly string url = "https://api.twitch.tv/kraken/";

        public TwitchAPICaller(string authCode, string channelName)
        {
            this.authCode = authCode;
            this.channelName = channelName;
            client = new RestClient(url);
            client.AddDefaultHeader("Authorization", "OAuth " + authCode);
        }

        public List<String> GetSubscribers()
        {
            List<string> names = new List<string>();
            RestRequest req = new RestRequest("channels/{channelName}/subscriptions", Method.GET);
            req.AddUrlSegment("channelName", channelName);

            while (true)
            {
                RestResponse resp = (RestResponse) client.Execute(req);
                string content = resp.Content;
                SubCall subCall = JsonConvert.DeserializeObject<SubCall>(content);
                if (subCall.Subs != null && subCall.Subs.Any())
                {
                    names.AddRange(subCall.Subs.Select(n => n.User.Name));
                    if (!String.IsNullOrEmpty(subCall.Links.Next))
                    {
                        req.Resource = subCall.Links.Next.Substring(url.Length);
                    }
                    else
                    {
                        return names;
                    }
                }
                else
                {
                    return names;
                }
            }
        }
    }
}
