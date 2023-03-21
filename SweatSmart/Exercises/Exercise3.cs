namespace SweatSmart.Exercises;

using SweatSmart.Abstract;

/// <summary>
/// Dati due elenchi di prodotti, trovare tutti i prodotti che sono presenti in entrambe le sequenze e che hanno un prezzo superiore a 100€.
/// Restituire una nuova sequenza contenente il nome e il prezzo di ciascun prodotto.
/// Utilizzare Where, Join e Select per combinare le sequenze e selezionare i campi necessari.
/// </summary>
public class Exercise3 : LinqExercise
{
    public override void Run()
    {
        var products1 = new[]
        {
            new { Name = "Product A", Price = 50 },
            new { Name = "Product B", Price = 100 },
            new { Name = "Product C", Price = 150 }
        };

        var products2 = new[]
        {
            new { Name = "Product A", Price = 75 },
            new { Name = "Product D", Price = 125 },
            new { Name = "Product E", Price = 200 }
        };
        
        throw new NotImplementedException();
    }
}