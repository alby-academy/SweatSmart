namespace SweatSmart.Exercises;

using Abstract;

/// Esercizio 11
// Dati due elenchi di numeri, trovare i numeri presenti solo nella prima lista e non nella seconda.
// Successivamente, stampare la somma di tali numeri e l'elenco dei numeri trovati. 
// Trova l'errore nel seguente codice
public class Exercise11 : LinqExercise
{
    public override void Run()
    {
        var list1 = new List<int> { 1, 2, 3, 4, 5 };
        var list2 = new List<int> { 3, 4, 5, 6, 7 };

        var query = list1.Except(list2);
        var sum = query.Sum();

        Console.WriteLine($"Numbers only in the first list: {string.Join(",", query)}");
        Console.WriteLine($"Sum of numbers: {sum}");
    }
}