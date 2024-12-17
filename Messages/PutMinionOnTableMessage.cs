namespace ServerTCP.Gaming.Messages
{
    public class PutMinionOnTableMessage
    {
        public string PutMinionUid { get; set; }
        public string SelectedMinionUid { get; set; }
        public int PutIndex { get; set; }
    }
}