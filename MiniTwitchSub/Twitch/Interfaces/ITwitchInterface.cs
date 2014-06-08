using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTwitchSub.Twitch.Interfaces
{
    public interface ITwitchInterface
    {
        List<string> GetSubscribers();
    }
}
