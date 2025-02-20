﻿using System;
using System.Collections.Generic;
using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class ChangeMinionsOnBoardDTO
    {
        public int[] PositionIndexes;
        public ChangeType ChangeType { get; set; }
        public List<CardInfo> BoardMinions { get; set; } = new ();
     
        [NonSerialized] public string UserId;
    }
}