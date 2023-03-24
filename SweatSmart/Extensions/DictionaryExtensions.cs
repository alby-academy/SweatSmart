namespace SweatSmart.Extensions;

public static class DictionaryExtensions
{
    public static void Print<TKey, TValue>(this IDictionary<TKey, TValue> elements)
    {
        Console.WriteLine("====================================================");
        elements.ToList().ForEach(element => Console.WriteLine(element));
        Console.WriteLine("====================================================");
    }
}