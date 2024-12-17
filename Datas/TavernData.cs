using System.Collections.Generic;

namespace ServerTCP.Gaming.Datas
{
    public class TavernData
    {
        public int CostReset;
        public int CostBuyCard;
        public int RoundTime;
        public int StartGold;
        public int MaxTavernLevel;
        public int MaxAmountCardInTable;
        public int MaxAmountCardInHand;
        public float SpeedAnimation;
        
        public List<TavernUpdateInfo> TavernUpdateInfos;

        public TavernUpdateInfo GetTavernUpdateInfo(int level)
        {
            return TavernUpdateInfos.Find(x=> x.Level == level);
        }
    }

    public class TavernUpdateInfo
    {
        public int Level;
        public int CostUpgrade;
        public int CountMinionInTavern;
    }
}