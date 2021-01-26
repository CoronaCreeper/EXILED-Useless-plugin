using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreepyWtyczkaOwO.Handlers
{
    class Player
    {

        public void OnJoin(JoinedEventArgs ev)
        {
            ev.Player.Broadcast(duration: 2, message: "<color=lime>Witaj na naszym serwerze! Jeśli chcesz, możesz dołączyć na naszego discorda</color> <b><color=red>discord.io/atlasownia</color></b>");
        }




    }
}
