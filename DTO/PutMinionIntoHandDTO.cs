using System;
using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class PutMinionIntoHandDTO
    {
        public CardInfo Card { get; set; }
        public PutTypeMinion PutTypeMinion { get; set; }
        [NonSerialized] public string UserId;
    }
}