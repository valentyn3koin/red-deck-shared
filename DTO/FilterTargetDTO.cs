using System.Collections.Generic;
using System;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class FilterTargetDTO
    {
        public List<CardInfo> Targets { get; set; } = new ();
        [NonSerialized] public string UserId;
    }
}