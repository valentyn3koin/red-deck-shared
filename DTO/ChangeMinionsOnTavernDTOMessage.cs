using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class ChangeMinionsOnTavernDTOMessage
    {
        public bool IsDirty;
        public List<CardInfo> TavernMinions = new List<CardInfo>();
        public ChangeType ChangeType;
    
        [NonSerialized] public string UserId;
    }
}