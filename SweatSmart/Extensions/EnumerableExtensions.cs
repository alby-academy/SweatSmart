namespace SweatSmart.Extensions;

public static class EnumerableExtensions
{
    public static void Print<T>(this IEnumerable<T> elements)
    {
        Console.WriteLine("====================================================");
        elements.ToList().ForEach(element => Console.WriteLine(element));
        Console.WriteLine("====================================================");
    }
}