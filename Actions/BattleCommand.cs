namespace ServerTCP.Gaming.Actions
{
    public class BattleCommand
    {
        public ActionBattleType ActionType { get; set; }
        public string? AdditionalData { get; set; }
    }
}