using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.Messages
{
    public class RefreshHeroesMessage
    {
        public HeroInfo[] Heroes { get; set; }
    }
}