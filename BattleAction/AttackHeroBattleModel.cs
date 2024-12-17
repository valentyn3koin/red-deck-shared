namespace ServerTCP.Gaming.BattleAction
{
    public class AttackHeroBattleModel
    {
        public string HeroUIdAttacker { get; set; }
        public int Damage { get; set; }
        public int OldHealth { get; set; }
        public int OldDefense { get; set; }
        public int CurrentHealth { get; set; }
        public int CurrentDefense { get; set; }
    }
}