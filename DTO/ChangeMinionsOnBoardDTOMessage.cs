using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class ChangeMinionsOnBoardDTOMessage
    {
        public bool IsDirty;
        public ChangeType ChangeType;
        public List<CardInfo> BoardMinions = new List<CardInfo>();
     
        [NonSerialized] public string UserId;
    }
}