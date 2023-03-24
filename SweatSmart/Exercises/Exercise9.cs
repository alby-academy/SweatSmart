namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Given a list of words, find all the words that contain the letter 'a' and have an even length.
///     Sort the words in descending order of length and return a new sequence containing the length of each word and the word itself.
///     Use Where, Contains, OrderByDescending, Select and Anonymous Types.
/// </summary>
public class Exercise9 : IExercise<object>
{
    public IEnumerable<object> Run()
    {
        var words = new[] { "apple", "banana", "cherry", "pear", "apricot" };

        return words
            .Where(word => word.Contains('a') && word.Length % 2 == 0)
            .OrderByDescending(word => word.Length)
            .Select(word => new { word.Length, Word = word });
    }
}