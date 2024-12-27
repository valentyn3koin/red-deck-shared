using ServerTCP.Gaming.Enums;
using ServerTCP.Utils.DataScripts;

namespace ServerTCP.Submodule.Datas
{
    public class DeckData
    {
        public ScriptableObjectType scriptableType;
        public RaceType raceType;
        public string[] cardsIds = {};
        public string[] summonsIds = {};
        public string id;
        public string deckName;
    }
}