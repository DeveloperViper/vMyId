using CitizenFX.Core;
using System;
using static CitizenFX.Core.Native.API;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playerid
{
    public class Main : BaseScript
    {
        public void MyidCommand(int source, List<object> args, string raw)
        {
            TriggerEvent("chat:addMessage", new 
            {
                color = new[] { 0, 0, 255 },
                multiline = true,
                args = new[] { source }
            });
        }
    }
}
