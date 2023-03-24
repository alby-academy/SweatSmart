namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Given two sequences of numbers, find all elements that are present in both sequences and return a new sequence containing their squares.
///     Use Intersect and Select methods.
/// </summary>
public class Exercise7 : IExercise<int>
{
    public IEnumerable<int> Run()
    {
        int[] firstList = { 1, 2, 3, 4, 5 };
        int[] secondList = { 3, 4, 5, 6, 7 };

        return firstList
            .Intersect(secondList)
            .Select(x => x * x);
    }
}