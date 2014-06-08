using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MiniTwitchSub
{
    public class SettingsConfig
    {
        [JsonProperty("client")]
        public string ClientId;

        [JsonProperty("redirect")]
        public string RedirectURI;

        [JsonProperty("channel")]
        public string ChannelName;

        [JsonProperty("file")]
        public string FileLocation;
    }
}
