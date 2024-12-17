using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Infos;

namespace ServerTCP.Gaming.BattleAction
{
    public class HeroAbilityBattleModel
    {
        public HeroInfo Hero;
        public CardInfo[] Targets;
        public AbilityType[] AbilityTypes;

        public bool IsDamageAbility()
        {
            bool isDamage = false;
            foreach (var abilityType in AbilityTypes)
            {
                if (abilityType == AbilityType.Damage)
                {
                    isDamage = true;
                    break;
                }
            }

            return isDamage;
        }
    }
}