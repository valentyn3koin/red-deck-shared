using System.Collections.Generic;
using RedDeck.Cards;

namespace ServerTCP.Gaming.Infos
{
    public class CardInfo
    {
        public string CardUid { get; set; }
        public string CardDataID { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public bool IsGold { get; set; }
        public List<CardBuffHistory> BuffHistory { get; set; }
        public List<CardStatusInfo> Statuses { get; set; }
    }
}