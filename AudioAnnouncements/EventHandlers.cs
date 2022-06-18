using AudioPlayer.API;
using Exiled.Events.EventArgs;
using Respawning;

namespace AudioAnnouncements
{
    public class EventHandlers
    {
        public void OnSpawnWave(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam == SpawnableTeamType.NineTailedFox)
                AudioController.PlayFromFile(Plugin.Instance.Config.MtfAudioPath);
            if (ev.NextKnownTeam == SpawnableTeamType.ChaosInsurgency)
                AudioController.PlayFromFile(Plugin.Instance.Config.CiAudioPath);
        }
    }
}
