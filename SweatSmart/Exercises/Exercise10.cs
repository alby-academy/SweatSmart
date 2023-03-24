namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Given a list of numbers, find the sum of the squares of the odd numbers and the sum of the cubes of the even numbers.
///     Return a list of two elements: the first containing the result for the odd numbers and the second containing the result for the even numbers.
///     Use Where, Select, Aggregate, and Math.
/// </summary>
public class Exercise10 : IExercise<double>
{
    public IEnumerable<double> Run()
    {
        var numbers = new[] { 1, 2, 3, 4, 5 };

        var odds = numbers
            .Where(n => n % 2 != 0)
            .Select(n => Math.Pow(n, 2))
            .Aggregate(0D, (acc, n) => acc + n);

        var even = numbers
            .Where(n => n % 2 == 0)
            .Select(n => Math.Pow(n, 3))
            .Aggregate(0D, (acc, n) => acc + n);

        return new[] { odds, even };
    }
}