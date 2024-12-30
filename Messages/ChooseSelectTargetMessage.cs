namespace ServerTCP.Gaming.Messages
{
    public class ChooseSelectTargetMessage
    {
        public string CasterUid { get; set; }
        public string TargetUid { get; set; }
        public bool IsCancel { get; set; }
    }
}