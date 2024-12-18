using System;

namespace ServerTCP.Gaming.Infos
{
    [Serializable]
    public class BattleHistory
    {
        public string AttackerUid;
        public string DefenderUid;
        public int Damage;
        
        public BattleHistory(string attackerUid, string defenderUid, int damage)
        {
            AttackerUid = attackerUid;
            DefenderUid = defenderUid;
            Damage = damage;
        }
    }
}