using System;
using System.Collections.Generic;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class RefreshHeroesDTO
    {
        public List<HeroInfo>  Heroes { get; set; }
        [NonSerialized] public string UserId;
    }
}