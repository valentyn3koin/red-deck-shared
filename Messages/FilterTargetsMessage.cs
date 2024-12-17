namespace ServerTCP.Gaming.Messages
{
    public class FilterTargetsMessage
    {
        public string AbilityId { get; set; }
        public string CasterUid { get; set; }
        public string[] Targets { get; set; }
    }
}