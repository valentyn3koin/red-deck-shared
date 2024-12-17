namespace ServerTCP.Gaming.Infos
{
    public class CardBuffHistory
    {
        public string CardDataId { get; set; }
        public int HealthBuff { get; set; }
        public int AttackBuff { get; set; }

        public bool IsAttackOnly => AttackBuff > 0 && HealthBuff == 0;
        public bool IsHealthOnly => HealthBuff > 0 && AttackBuff == 0;
        public bool IsAttackAndHealth => AttackBuff > 0 && HealthBuff > 0;
        
        public CardBuffHistory(string cardDataId, int healthBuff, int attackBuff)
        {
            CardDataId = cardDataId;
            HealthBuff = healthBuff;
            AttackBuff = attackBuff;
        }
    }
}