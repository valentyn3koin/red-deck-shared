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
        AllCardsAllPiles = 12,
        
        
        AllSlots = 15,
        AllCardData = 17,     
        
        AllMyCards = 21,
        AllCards = 22,
        AllOpponentCards = 23,
        AllMyCardsInTavern = 25,
        
     
        //For card Create effects only

        PlayTarget = 20,        //The target selected at the same time the spell was played (spell only)      
        AbilityTriggerer = 25,   //The card that triggered the trap
        EquippedCard = 27,       //If equipment, the bearer, if character, the item equipped

        SelectTarget = 30,        //Select a card, player or slot on board
        CardSelector = 40,          //CardModel selector menu
        ChoiceSelector = 50,        //Choice selector menu

        LastPlayed = 70,            //Last card that was played 
        LastTargeted = 72,          //Last card that was targeted with an ability
        LastDestroyed = 74,            //Last card that was killed
        LastSummoned = 77,            //Last card that was summoned or created
        MyTargets = 78,
    }
}