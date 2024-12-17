using Newtonsoft.Json;

namespace ServerTCP.Gaming.Actions
{
    public class BattleCommand
    {
        public ActionBattleType ActionType;
        public string AdditionalData;

        public BattleCommand(ActionBattleType actionType, string additionalData = null)
        {
            ActionType = actionType;
            AdditionalData = additionalData;
        }

        public static BattleCommand CreateAction<T>(ActionBattleType actionType, T data)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            return new BattleCommand(actionType, jsonData);
        }
    }
}