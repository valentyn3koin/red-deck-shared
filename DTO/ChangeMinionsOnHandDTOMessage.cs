using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class ChangeMinionsOnHandDTOMessage
    {
        public bool IsDirty;
        public PutTypeMinion PutTypeMinion;
        public ChangeType ChangeType;
        public List<CardInfo> HandMinions = new List<CardInfo>();
     
        [NonSerialized] public string UserId;
    }
}