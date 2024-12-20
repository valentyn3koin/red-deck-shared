using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class PlayerReadyDTO
    {
        public string UserId { get; set; }
        public HeroInfo HeroInfo { get; set; }
        public bool IsReady { get; set; }
    }
}