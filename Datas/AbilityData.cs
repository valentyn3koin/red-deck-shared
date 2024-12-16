using ServerTCP.Gaming.Enums;
using ServerTCP.Gaming.Models;

namespace ServerTCP.Gaming.Datas
{
    public class AbilityData
    {
        public string ID;
        public TargetType TargetType;
        public AbilityTrigger Trigger;
        public AbilityTarget TargetList;
        public AbilityTarget AdditionalList;
        public AbilityFilterTarget[] FilterTargets;
        public string[] Ids;
        public AbilityType Type;
        public AmountType AmountType;
        public int Value;
        public bool IsPermanentlyEffect;
        public AbilityEffect AbilityEffect;
        public StatusType GameStatus;
        public int Duration;
        public string[] ChainAbilitiesIds;
        public int ManaCost;
        public bool Exhaust;
        public bool ChargeTarget;
        public StatusType[] ViewStatusTypes;
        public bool Stackable;

        /*
        public StatusData Status(IResourceManager dataResource)
        {
            return dataResource.GetStatusDataById(GameStatus);
        }

        public AbilityData[] ChainAbilities(IResourceManager dataResource)
        {
            List<AbilityData> all = new();

            if (ChainAbilitiesIds != null && ChainAbilitiesIds.Length > 0)
            {
                foreach (string abilitiesId in ChainAbilitiesIds)
                {
                    AbilityData ability = dataResource.GetAbilityDataById(abilitiesId);

                    if (ability != null)
                    {
                        all.Add(ability);
                    }
                }
            }

            return all.ToArray();
        }

        public AbilityModel CreateModel(IResourceManager abliDataResource)
        {
            return new(this, abliDataResource);
        }
        */
    }
}