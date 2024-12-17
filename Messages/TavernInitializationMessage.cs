using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.Messages
{
    public class TavernInitializationMessage
    {
        public List<CardInfo> CardModels { get; set; } = new List<CardInfo>();
        public List<HeroInfo> HeroModels { get; set; } = new List<HeroInfo>();
    }
}