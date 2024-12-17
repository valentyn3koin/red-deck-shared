using System;
using System.Collections.Generic;
using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class ChangeMinionsOnTavernDTOMessage
    {
        public List<CardInfo> TavernMinions { get; set; } = new List<CardInfo>();
        public ChangeType ChangeType { get; set; }
    
        [NonSerialized] public string UserId;
    }
}