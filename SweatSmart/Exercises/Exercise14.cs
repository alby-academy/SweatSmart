namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Given a list of strings, find:
///     1. the first string that starts with the letter "A"
///     2. the last string that ends with the letter "B",
///     3. the third string in the list,
///     4. the total number of strings in the list, and whether the list contains the string "Ciao".
///     Use the FirstOrDefault, LastOrDefault, ElementAtOrDefault, Count, and Contains methods.
///     Return an enumeration of the resulting strings.
/// </summary>
public class Exercise14 : IExercise<string>
{
    public IEnumerable<string> Run()
    {
        var words = new List<string>
        {
            "love", "house", "entertainment", "elephant", "sheet", "newspaper", "image", "jazz", "karaoke",
            "lake", "mountain", "ship", "apple", "ear", "fish", "painting", "frog", "sun", "table", "grape",
            "apricot", "wine", "yoga", "sugar"
        };

        yield return words.FirstOrDefault(s => s.StartsWith("a")) ?? "None";
        yield return words.LastOrDefault(s => s.EndsWith("b")) ?? "None";
        yield return words.ElementAtOrDefault(2) ?? "None";
        yield return $"{words.Count}";
        yield return words.Contains("Ciao") ? "Yes" : "No";
    }
}