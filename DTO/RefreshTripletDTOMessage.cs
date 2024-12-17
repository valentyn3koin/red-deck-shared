using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.DTO
{
    public class RefreshTripletDTOMessage
    {
        public bool IsDirty;
        public List<string> RemovedCardUids;
        public CardInfo CreatedNewModel;
    
        [NonSerialized] public string UserId;
    }
}