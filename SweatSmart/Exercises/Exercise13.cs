namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Scrivi una query LINQ che restituisce il nome del frutto con la quantità massima in magazzino.
/// </summary>
public class Exercise13 : LinqExercise
{
    public override void Run()
    {
        var fruits = new Dictionary<string, int>
        {
            { "Apple", 10 },
            { "Orange", 15 },
            { "Banana", 5 },
            { "Pear", 20 }
        };

        var result = fruits.MaxBy(x => x.Value);

        Console.WriteLine($"Fruit with more amount: {result}");
    }
}