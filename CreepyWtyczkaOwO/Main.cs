using Exiled.API.Enums;
using Exiled.API.Features;
using System;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace CreepyWtyczkaOwO
{
    public class Main :Plugin<Config>
    {
        private static readonly Lazy<Main> LazyInstance = new Lazy<Main>(valueFactory: () => new Main());
        public Main Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Player player;
        private Handlers.Server server;


        private Main()
        {
        }

        public override void OnEnabled()
        {
            Console.WriteLine("###########################################");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 10% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 20% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 30% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 40% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 50% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 60% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 70% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 80% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 90% #");
            Console.WriteLine("# Zjebany plugin creepera - aktywuję = 100%#");
            Console.WriteLine("# Zjebany plugin creepera - aktywowano     #");
            Console.WriteLine("###########################################");

        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }

        public void RegisterEvents()

        {
            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Server.RoundStarted += server.OnRoundStarted;
        }

        public void UnregisterEvents()
        {
            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Server.RoundStarted += server.OnRoundStarted;

            player = null;
            server = null;
        }

    }
}
