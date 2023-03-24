namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Suppose we have two lists of words, A and B, and we need to find the words that are present only in A or only in B, but not in both.
///     Additionally, we want to find the words that are present in both A and B, but only if they have an even number of letters, and return the first list concatenated with the second list.
///     Use Except, Union, Intersect, and Concat methods.
/// </summary>
public class Exercise11 : IExercise<string>
{
    public IEnumerable<string> Run()
    {
        var a = new List<string> { "apple", "banana", "orange", "kiwi", "grape" };
        var b = new List<string> { "banana", "pear", "kiwi", "grapefruit", "cherry" };

        var result1 = a.Union(b).Except(b.Intersect(a));
        var result2 = a.Intersect(b).Where(n => n.Length % 2 == 0);

        return result1.Concat(result2);
    }
}