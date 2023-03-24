namespace SweatSmart.Exercises;

using Abstract;
using Extensions;

/// <summary>
///     What is the error in the following code and how would you fix it?
/// </summary>
public class Exercise4 : IExercise<int>
{
    public IEnumerable<int> Run()
    {
        var even = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
            .Where(n => n % 2 == 0);

        even.Print();

        return even;
    }
}