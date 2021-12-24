using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using System;
using System.Collections.Generic;

namespace Server
{
	public class Server : BaseScript
	{
        [Command("myid")]
        public void MyidCommand(int source, List<object> args, string raw)
        {
            TriggerClientEvent(Players[source], "chat:addMessage", new
            {
                color = new[] { 0, 0, 255 },
                multiline = true,
                args = new[] { source }
            });
        }
    }
}

