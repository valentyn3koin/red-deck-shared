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
    }
}