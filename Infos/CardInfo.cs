using System.Collections.Generic;
using ServerTCP.Gaming.Enums;
using ServerTCP.Submodule.Enums;

namespace ServerTCP.Gaming.Infos
{
    public class CardInfo
    {
        public string CardUid { get; set; }
        public string CardDataID { get; set; }
        public string OwnerId { get; set; }
        public RaceType RaceType { get; set; }
        public RareType RareType { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public bool IsGold { get; set; }
        public List<CardBuffHistory> BuffHistory { get; set; }
        public List<CardStatusInfo> Statuses { get; set; }
        public List<MechanicCards> Mechanics { get; set; }
    }
}