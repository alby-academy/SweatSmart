namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Dati due elenchi di numeri, trovare tutti gli elementi che sono presenti in entrambe le sequenze
///     e restituire una nuova sequenza contenente i loro quadrati.
///     Utilizzare Intersect, Select
/// </summary>
public class Exercise2 : LinqExercise
{
    public override void Run()
    {
        int[] firstList = { 1, 2, 3, 4, 5 };
        int[] secondList = { 3, 4, 5, 6, 7 };

        var result = firstList.Intersect(secondList).Select(x => $"Square of {x} is {x * x}");

        foreach (var i in result) Console.WriteLine(i);
    }
}