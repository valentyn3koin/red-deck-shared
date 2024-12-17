using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.BattleAction
{
    public class InitializationBattleModel
    {
        public HeroInfo PlayerHero { get; set; }
        public HeroInfo OpponentHero {get; set;}
        
        public CardInfo[] PlayerCharacters { get; set; }
        public CardInfo[] OpponentCharacters { get; set; }
    }
}