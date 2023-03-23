namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
/// Supponiamo di avere un elenco di stringhe e vogliamo trovare la prima stringa che inizia con la lettera "A",
/// l'ultima stringa che finisce con la lettera "B", la terza stringa dell'elenco,
/// il numero totale di stringhe e se l'elenco contiene la stringa "Ciao".
/// Utilizzare i metodi First, Last, ElementAt, Count e Contains.
/// </summary>
public class Exercise9 : LinqExercise
{
    public override void Run()
    {
        var words = new List<string>
        {
            "amore", "banana", "casa", "divertimento", "elefante", "foglio", "giornale", "immagine", "jazz", "karaoke",
            "lago", "montagna", "nave", "orecchio", "pesce", "quadro", "rana", "sole", "tavolo", "uva",
            "vino", "yoga", "zucchero"
        };

        Console.WriteLine($"First string finisces with\'a\': {(words.Where(p => p.First() == 'A').Count() > 0 ? words.Where(p => p.First() == 'a').First() : "None")}");
        Console.WriteLine($"Last string finishes with \'b\': {words.Where(p => p.Last() == 'b').Last()}");
        Console.WriteLine($"The third element at list: {words.ElementAt(2)}");
        Console.WriteLine($"Total number of elements: {words.Count}");
        Console.WriteLine($"List contains \"Ciao\"? {(words.Contains("Ciao") ? "Yes!" : "No")}");
    }
}