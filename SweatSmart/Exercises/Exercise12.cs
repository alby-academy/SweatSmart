namespace SweatSmart.Exercises;

using SweatSmart.Abstract;

public class Exercise12 : LinqExercise
{
    /// <summary>
    /// Trova l'errore nel seguente codice e spiega perché il risultato è sbagliato. => Defference Execution
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public override void Run()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = numbers.Where(x => x % 2 == 0);

        var result = evenNumbers.Select(x => x * x).Where(x => x % 2 != 0).Sum();

        Console.WriteLine($"Result: {result}");
    }
}