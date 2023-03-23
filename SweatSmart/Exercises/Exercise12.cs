namespace SweatSmart.Exercises;

using Abstract;

public class Exercise12 : LinqExercise
{
    /// <summary>
    ///     Trova l'errore nel seguente codice e spiega perché il risultato è sbagliato. => Defference Execution
    public override void Run()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var query = numbers.Where(n => n % 2 == 0);

        // Aggiungiamo un nuovo numero alla lista
        numbers.Add(6);

        // Iteriamo sulla query
        foreach (var num in query) Console.WriteLine(num);
    }
}