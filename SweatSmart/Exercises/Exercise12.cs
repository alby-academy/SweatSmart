namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Suppose we have a list of 1000 random integers between 1 and 10000.
///     We want to create a new sequence that satisfies the following conditions:
///     1) Contains the first 5 numbers of the original sequence.
///     2) Contains all the numbers in the original sequence that are greater than 5000, up to and including the first number that is less than or equal to 5000.
///     3) Skips the first 200 numbers of the original sequence.
///     4) Skips all the numbers in the original sequence that are less than 3000.
///     5) Inverts the resulting sequence.
///     Use Take, Range, Select, Concat, Skip, SkipWhile, and Reverse methods.
/// </summary>
public class Exercise12 : IExercise<int>
{
    public IEnumerable<int> Run()
    {
        var rnd = new Random();
        var numbers = Enumerable
            .Range(1, 10000)
            .Select(item => rnd.Next(1, 10001)).ToList();

        return numbers
            .Take(5)
            .Concat(numbers.TakeWhile(x => x > 5000))
            .Skip(200)
            .SkipWhile(x => x < 3000)
            .Reverse();
    }
}