using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.BattleAction
{
    public class CreateMinionBattleModel
    {
        public CardInfo Caster { get; set; }
        public CardInfo[] SummonedUids { get; set; }
        public string HeroUid { get; set; }
    }
}