namespace SweatSmart.Exercises;

using Abstract;
using Model;

/// <summary>
///     Given two lists of products, find all the products that are present in both sequences whose sum of prices is over 100€.
///     Return a new sequence containing the name and price of each product.
///     Use Where, Join to combine the sequences and select the necessary fields.
/// </summary>
public class Exercise8 : IExercise<Product>
{
    public IEnumerable<Product> Run()
    {
        var products1 = new Product[]
        {
            new("Product A", 50),
            new("Product B", 100),
            new("Product C", 150),
            new("Product F", 10)
        };

        var products2 = new Product[]
        {
            new("Product A", 75),
            new("Product D", 125),
            new("Product E", 200),
            new("Product F", 95)
        };

        return products1
            .Join(
                products2,
                nameProd1 => nameProd1.Name,
                nameProd2 => nameProd2.Name,
                (nameProd1, nameProd2) => new Product(nameProd2.Name, nameProd1.Price + nameProd2.Price))
            .Where(price => price.Price >= 100);
    }
}