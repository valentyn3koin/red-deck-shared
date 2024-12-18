using System;
using System.Collections.Generic;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class RefreshTripletDTO
    {
        public List<string> RemovedCardUids { get; set; } = new List<string>();
        public CardInfo CreatedNewModel { get; set; } 
    
        [NonSerialized] public string UserId;
    }
}