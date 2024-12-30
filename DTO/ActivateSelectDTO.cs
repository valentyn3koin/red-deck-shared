using System;
using System.Collections.Generic;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class ActivateSelectDTO
    {
        public List<string> CardsForChoose { get; set; } = new();
        [NonSerialized] public string UserId;
    }
}