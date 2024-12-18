using System;
using System.Collections.Generic;
using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class ChangeMinionsOnHandDTO
    {
        public PutTypeMinion PutTypeMinion { get;set; }
        public ChangeType ChangeType { get; set; }
        public List<CardInfo> HandMinions { get; set; } = new List<CardInfo>();

        [NonSerialized] public string UserId;
    }
}