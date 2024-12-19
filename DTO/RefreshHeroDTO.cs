using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class RefreshHeroDTO
    {
        public HeroInfo Hero { get; set; }
        
        [NonSerialized] public string UserId;
    }
}