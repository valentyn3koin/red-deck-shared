using System.Collections.Generic;

namespace ServerTCP.Gaming.Infos
{
    public class PlayerInfo
    {
        public int Gold { get; set; }
        public HeroInfo OpponentHeroModel { get; set; }
        public List<CardInfo> GetCardsBoard { get; set; }
        public List<CardInfo> GetCardsInTavern { get; set; }
        public List<CardInfo> GetCardsHand { get; set; }
        public HeroInfo HeroModel { get; set; }
    }
}