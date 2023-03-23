namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Dati due elenchi di prodotti, trovare tutti i prodotti che sono presenti in entrambe
///     le sequenze la cui somma dei prezzi e' superiore a 100€.
///     Restituire una nuova sequenza contenente il nome e il prezzo di ciascun prodotto.
///     Utilizzare Where, Join e Select per combinare le sequenze e selezionare i campi necessari.
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

        var result = products1
            .Join(
                products2,
                nameProd1 => nameProd1.Name,
                nameProd2 => nameProd2.Name,
                (nameProd1, nameProd2) => new
                {
                    nameProd2.Name,
                    Price = nameProd1.Price + nameProd2.Price,
                    Description = $"The price(s) of {nameProd1.Name} is {nameProd1.Price} and {nameProd2.Price}"
                })
            .Where(price => price.Price >= 100);

        foreach (var v in result) Console.WriteLine(v.Description);
    }
}