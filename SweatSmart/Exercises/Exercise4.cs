namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Dato un elenco di parole, trovare tutte le parole che contengono la lettera 'a' e che hanno una lunghezza pari.
///     Ordinare le parole in ordine decrescente di lunghezza e restituire una nuova sequenza contenente
///     la lunghezza di ogni parola e la parola stessa.
///     Utilizzare Where, OrderByDescending, Select e Anonymous Types.
/// </summary>
public class Exercise4 : LinqExercise
{
    public override void Run()
    {
        var words = new[] { "apple", "banana", "cherry", "pear", "apricot" };

        var result = words
            .Where(x => x.Contains('a') && x.Length % 2 == 0)
            .OrderByDescending(s => s.Length)
            .Select(p => new { p.Length, word = p });

        foreach (var i in result) Console.WriteLine(i);
    }
}