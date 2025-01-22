namespace ServerTCP.Gaming.Enums
{
    public enum AbilityTrigger
    {
        None = 0,

        Ongoing = 2,  //Always active (does not work with all effects)
        Activate = 5, //Action

        OnPlay = 10,  //When playeds
        OnPlayOther = 12,  //When another card played
        OnFriendlyBlast = 13,
        OnFriendlyAddHealth = 14,

        StartOfTurn = 20, //Every turn
        EndOfTurn = 22, //Every turn

        OnBeforeAttack = 30, //When attacking, before damage
        OnAfterAttack = 31, //When attacking, after damage if still alive
        OnBeforeDefend = 32, //When being attacked, before damage
        OnAfterDefend = 33, //When being attacked, after damage if still alive
        OnKill = 35,        //When killing another card during an attack
        OnTakingDamage = 36, //When taking damage
        
        OnDeathFriendly = 39,
        OnDeath = 40, //When dying
        OnFriendlyDeathRattle = 41,
        OnDeathOther = 42, //When another dying
        OnDamaged = 44, //When damaged
        OnSurviveAfterBattle = 46, //When surviving an attack
        OnBattleStart = 47, //When battle starts
        OnReborn = 48,
        OnAvenge = 49,
        OnButtonClick = 50, //When button clicked
        OnRebornOther = 51,
        OnBarrierFall = 52,
        OnFriendlyCyberneticDeath = 53,
        OnDie
    }
}