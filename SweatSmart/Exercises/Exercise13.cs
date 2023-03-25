namespace SweatSmart.Exercises;

using Abstract;
using Model;

/// <summary>
///     Suppose we have a list of products, each of which has a price and a category.
///     We want to create a new sequence that groups the products by category and calculates the average price of the products in each category.
///     Additionally, we want to order the results in descending order of the average price.
///     We can use the GroupBy, Select, Average, Anonymous Types and OrderByDescending methods to accomplish this task.
/// </summary>
public class Exercise13 : IExercise<object>
{
    public IEnumerable<object> Run()
    {
        var products = new Product[]
        {
            new("Product1", 10m, "Category1"),
            new("Product2", 15m, "Category2"),
            new("Product3", 20m, "Category1"),
            new("Product4", 50m, "Category3"),
            new("Product5", 25m, "Category2"),
            new("Product6", 30m, "Category3"),
            new("Product7", 15m, "Category1"),
            new("Product8", 20m, "Category2"),
            new("Product9", 10m, "Category3")
        };

        return products
            .AsEnumerable()
            .GroupBy(
                product => product.Category,
                product => product.Price,
                (category, prices) => new { Category = category, Price = prices.Average(price => price) })
            .OrderByDescending(p => p.Price);
    }
}