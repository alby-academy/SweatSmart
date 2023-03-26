namespace SweatSmart.Extensions;

using System.Collections;

public static class PrintExtensions
{
    public static void Print(this IEnumerable elements, string? step = default)
    {
        step.PrintSeparator();

        foreach (var element in elements)
            if (element.GetType().IsGenericType && element.GetType().GetGenericTypeDefinition() == typeof(KeyValuePair<,>))
            {
                var key = element.GetType().GetProperty("Key")?.GetValue(element);
                var value = element.GetType().GetProperty("Value")?.GetValue(element);

                Console.WriteLine("{0}:", key);
                foreach (var city in (value as IEnumerable)!) Console.WriteLine(city);
            }
            else
            {
                Console.WriteLine(element);
            }

        string.Empty.PrintSeparator();
    }

    public static void PrintSeparator(this string? step)
    {
        var title = step is null ? string.Empty : $"{step.ToUpperInvariant()} ";
        var separator = string.Concat(Enumerable.Repeat('=', 50 - title.Length));

        Console.WriteLine(string.Concat(title, separator));
    }
}