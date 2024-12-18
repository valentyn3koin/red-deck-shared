namespace ServerTCP.Gaming.Enums
{
    public static class MessageType
    {
        // Constants for networking messages
        public const string Connection = "connection";
        public const string Response = "response";
        public const string Action = "action";
        public const string OpponentFound = "opponentFound";
        public const string Cheating = "cheating";
        
        // Constants for game actions
        public const string CardPurchase = "CardPurchase";
        public const string ChangeMinionPosition = "ChangeMinionPosition";
        public const string SellMinion = "SellMinion";
        public const string PlaySpell = "PlaySpell";
        public const string PutMinionOnTable = "PutMinionOnTable";
        public const string TavernModelInitialization = "TavernModelInitialization";
        public const string UpdatePlayerModel = "UpdatePlayerModel";
        public const string FindOpponent = "FindOpponent";
        public const string ChooseHero = "ChooseHero";
        public const string ReadyPlayer = "ReadyPlayer";
        public const string UpgradeTavern = "UpgradeTavern";
        public const string RefreshTavern = "RefreshTavern";
        public const string FreezeTavern = "FreezeTavern";
        public const string UpdateDTO = "UpdateDTO";
        public const string ChooseOfThree = "ChooseOfThree";
        
        public const string StartBattle = "StartBattle";
        public const string RefreshHeroes = "RefreshHeroes";
        public const string LoseGame = "LoseGame";
        public const string WinGame = "WinGame";
        public const string ActivateHeroSkill = "ActivateHeroSkill";
        public const string FilterTargets = "FilterTargets";
    }
}