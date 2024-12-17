using System;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class RefreshTavernDTO
    {
        public CardInfo[] Cards { get; set; } = Array.Empty<CardInfo>();
        public bool IsHaveFreeze { get; set; }
    }
}