namespace ServerTCP.Gaming.Messages
{
    public class RoomJoinedMessage
    {
        public string RoomId { get; set; }
        public string? WhoJoinedToRoomUserId { get; set; }
        public int Capacity { get; set; }
    }
}