using System.Collections.Generic;

namespace ServerTCP.Gaming.Infos
{
    public class HeroInfo
    {
        public ulong ClientId { get; set; }
        public string Uid { get; set; }
        public string HeroDataID { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public bool IsSkillUsed { get; set; }
        public AbilityInfo AbilityModel { get; set; }
        
        public int TavernLevel { get; set; }
        public string FavoriteType { get; set; }
        public int FavoriteAmount { get; set; }
        public int TripletAmount { get; set; }
        public List<BattleHistory> BattleHistories { get; set; }
    }
}