namespace ServerTCP.Gaming.Messages
{
    public class ChangeMinionPositionMessage
    {
        public string CardUid { get; set; }
        public int MinionIndex { get; set; }
    }
}