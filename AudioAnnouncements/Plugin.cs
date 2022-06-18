using Exiled.API.Features;
using Server = Exiled.Events.Handlers.Server;
using System;

namespace AudioAnnouncements
{
    public class Plugin : Plugin<Config>
    {
        private EventHandlers _events;

        public static Plugin Instance;

        public override string Name { get; } = "AudioAnnouncements";
        public override string Author { get; } = "Heisenberg3666";
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 0);
        public override Version Version { get; } = new Version(1, 0, 0, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Instance = this;
            _events = new EventHandlers();
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            _events = null;
            Instance = null;
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            Server.RespawningTeam += _events.OnSpawnWave;
        }

        public void UnregisterEvents()
        {
            Server.RespawningTeam -= _events.OnSpawnWave;
        }
    }
}
