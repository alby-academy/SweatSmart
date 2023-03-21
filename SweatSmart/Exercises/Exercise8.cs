namespace SweatSmart.Exercises;

using SweatSmart.Abstract;

/// <summary>
/// Supponiamo di avere un elenco di prodotti, ognuno dei quali ha un prezzo e una categoria.
/// Vogliamo creare una nuova sequenza che raggruppi i prodotti per categoria e calcoli il prezzo medio dei prodotti in ciascuna categoria.
/// Inoltre, vogliamo ordinare i risultati in ordine decrescente di prezzo medio.
/// Utilizzare GroupBy Select Average OrderByDescending
/// </summary>
public class Exercise8 : LinqExercise
{
    public override void Run()
    {
        var products = new List<Product>
        {
            new() { Name = "Prodotto 1", Category = "Categoria 1", Price = 10 },
            new() { Name = "Prodotto 2", Category = "Categoria 2", Price = 15 },
            new() { Name = "Prodotto 3", Category = "Categoria 1", Price = 20 },
            new() { Name = "Prodotto 4", Category = "Categoria 3", Price = 5 },
            new() { Name = "Prodotto 5", Category = "Categoria 2", Price = 25 },
            new() { Name = "Prodotto 6", Category = "Categoria 3", Price = 30 },
            new() { Name = "Prodotto 7", Category = "Categoria 1", Price = 15 },
            new() { Name = "Prodotto 8", Category = "Categoria 2", Price = 20 },
            new() { Name = "Prodotto 9", Category = "Categoria 3", Price = 10 }
        };
        
        throw new NotImplementedException();
    }

    private class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}