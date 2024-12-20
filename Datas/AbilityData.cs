using System;
using ServerTCP.Gaming.Enums;
using ServerTCP.Utils.DataScripts;

namespace ServerTCP.Gaming.Datas
{
    public class AbilityData
    {
        public ScriptableObjectType scriptableType;
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
    }
}