using AudioPlayer.API;
using Exiled.Events.EventArgs;
using MEC;
using Respawning;

namespace AudioAnnouncements
{
    public class EventHandlers
    {
        public void OnSpawnWave(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam == SpawnableTeamType.NineTailedFox)
                Timing.CallDelayed(Plugin.Instance.Config.AudioDelay, () =>
                {
                    AudioController.PlayFromFile(Plugin.Instance.Config.MtfAudioPath);
                });
            if (ev.NextKnownTeam == SpawnableTeamType.ChaosInsurgency)
                Timing.CallDelayed(Plugin.Instance.Config.AudioDelay, () =>
                {
                    AudioController.PlayFromFile(Plugin.Instance.Config.CiAudioPath);
                });
        }
    }
}
