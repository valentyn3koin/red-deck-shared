using ServerTCP.Gaming.Enums;

namespace ServerTCP.Gaming.BattleAction
{
    public class StatusValueInfo
    {
        public string CharacterUid { get; set; }
        public bool IsActive { get; set; }
        public StatusType StatusType { get; set; }
    }
}