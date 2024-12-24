using Newtonsoft.Json;
using ServerTCP.Gaming.Actions;

namespace ServerTCP.Submodule.Utils;

public static class BattleCommandExtensions
{
    public static BattleCommand CreateAction<T>(this BattleCommand battleCommand, ActionBattleType actionType, T data)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        return new BattleCommand()
        {
            ActionType = actionType,
            AdditionalData = jsonData
        };
    }
    
    public static T? TakeAction<T>(this BattleCommand battleCommand)
    {
        if (string.IsNullOrEmpty(battleCommand.AdditionalData))
        {
            return default;
        }
        return JsonConvert.DeserializeObject<T>(battleCommand.AdditionalData);
    }
}