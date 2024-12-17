using ServerTCP.Gaming.Actions;

namespace ServerTCP.Gaming.Messages
{
    public class StartBattleMessage
    {
        public BattleCommand[] BattleActions { get; set; }
    }
}