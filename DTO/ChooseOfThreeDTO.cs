using System;
using System.Collections.Generic;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class ChooseOfThreeDTO
    {
        public List<CardInfo> CardModels { get; set; }
        [NonSerialized] public string UserId;
    }
}