using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniTwitchSub.Twitch.Interfaces;

namespace MiniTwitchSub.Twitch
{
    public class FakeTwitchAPICaller : ITwitchInterface
    {
        public List<string> GetSubscribers()
        {
            using (StreamReader file = new StreamReader("C:\\Users\\Matt\\Desktop\\testUsers.txt"))
            {
                return file.ReadToEnd().Split(',').ToList();
            }
        }
    }
}
