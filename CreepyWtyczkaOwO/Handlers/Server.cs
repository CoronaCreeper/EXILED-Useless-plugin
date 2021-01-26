using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreepyWtyczkaOwO.Handlers
{
    class Server : ServerBase1
    {
        public void OnWaitingForPlayers()
        {
            Log.Info(message: "============SERWER JEST URUCHOMIONY============");
        }

        public new void OnRoundStarted()
        {
            Map.Broadcast(duration: 6, message: "<color=orange>Pamiętaj aby wjeść na naszego discorda!</color> <b><color=lime>discord.io/atlasownia</color></b>");
        }
    }

    internal class ServerBase1
    {
    }
}
