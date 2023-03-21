namespace SweatSmart.Exercises;

using SweatSmart.Abstract;

/// <summary>
/// scrivi una query LINQ che restituisce il nome del frutto con la quantità massima in magazzino.
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
        
        throw new NotImplementedException();
    }
}