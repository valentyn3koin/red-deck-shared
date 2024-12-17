namespace ServerTCP.Gaming.DTO
{
    public class RefreshGoldDTOMessage
    {
        public bool IsDirty;
        public int Gold;
        public int MaxGold;
        public int GoldCostTavernUpgrade;
        public int GoldCostRefresh;
    
        [NonSerialized] public string UserId;
    }
}