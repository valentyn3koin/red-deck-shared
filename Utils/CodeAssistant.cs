namespace ServerTCP.Submodule.Utils;

public static class CodeAssistant
{
    public static T RandomElement<T>(this T[] array)
    {
        return array[array.RandomIndex()];
    }
    
    public static int RandomIndex<T>(this T[] array)
    {
        Random random = new Random();
        return random.Next(0, array.Length);
    }
}