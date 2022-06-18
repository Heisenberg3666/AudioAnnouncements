using Exiled.API.Interfaces;

namespace AudioAnnouncements
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; }

        public string MtfAudioPath { get; set; }
        public string CiAudioPath { get; set; }
    }
}
