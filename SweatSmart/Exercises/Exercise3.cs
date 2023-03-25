namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     In this exercise, the code provided utilizes the Min, Max, and Sum LINQ methods to find the minimum number, maximum number, and sum of a range of integers.
///     However, there is an error in the code that could result in multiple enumerations. The task is to identify the error and provide a solution to fix it.
/// </summary>
public class Exercise3 : IExercise<int>
{
    public IEnumerable<int> Run()
    {
        var query = Enumerable.Range(0, 10);

        var min = query.Min();
        var max = query.Max();
        var sum = query.Sum();

        Console.WriteLine("Min number: {0}", min);
        Console.WriteLine("Max number: {0}", max);
        Console.WriteLine("Sum of numbers: {0}", sum);

        var result = new List<int> { min, max, sum };

        return result;
    }
}