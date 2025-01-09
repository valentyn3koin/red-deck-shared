namespace ServerTCP.Gaming.Enums
{
    public enum AbilityTarget
    {
        None = 0,
        Self = 1,

        HeroSelf = 2,
        PlayerSelf = 4,
        PlayerOpponent = 5,
        AllPlayers = 7,
        
        AllCurrentOpponentsCardsBoard = 8,
        AllCurrentMyCardsBoard = 9,
        AllCurrentCardsBoard = 10,
        AllCardsHand = 11,
        AllCardData = 17,     
        
        AllMyCards = 21,
        AllOpponentCards = 23,
        AllMyCardsInTavern = 25,
        MyTargets = 78,
        
        AllCardDataCharacters = 79,
        AllCardDataSummons = 80,
        TakeDamageTarget = 81,
    }
}