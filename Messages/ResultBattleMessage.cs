using System;

namespace ServerTCP.Gaming.Messages
{
    public class ResultBattleMessage 
    {
        public bool isWin { get; set; }
        
        [NonSerialized] public string UserId;
    }
}