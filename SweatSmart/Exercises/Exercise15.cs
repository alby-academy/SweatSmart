namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Suppose you have a list of numbers.
///     Create a program that uses the GroupBy method to group the numbers based on their even or odd value and create a dictionary containing two groups of numbers: one for even numbers and one for odd numbers.
///     Use the ToDictionary method to create the dictionary.
/// </summary>
public class Exercise15 : IExercise<string, IEnumerable<int>>
{
    public Dictionary<string, IEnumerable<int>> Run()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        return numbers
            .GroupBy(n => n % 2 == 0 ? "Even" : "Odd")
            .ToDictionary(g => g.Key, g => g.AsEnumerable());
    }
}