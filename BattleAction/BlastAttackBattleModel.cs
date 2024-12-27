namespace ServerTCP.Gaming.BattleAction
{
    public class BlastAttackBattleModel
    {
        public string AttackerUid {get; set;}
        public string[] DefenderUid {get; set;}
        public BlastType BlastType {get; set;}
    }

    public enum BlastType
    {
        Fire,
        Frost
    }
}