namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Identify the error in the following code and explain why the output is not as expected?
///     The code uses the Where method to filter even numbers from a list, but then adds a new number to the list after creating the query.
///     Hint: Consider the concept of deferred execution.
///     The desired result is 2 and 4.
/// </summary>
public class Exercise5 : IExercise<int>
{
    public IEnumerable<int> Run()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var query = numbers.Where(n => n % 2 == 0);

        numbers.Add(6);

        var result = query.ToList();

        return result;
    }
}