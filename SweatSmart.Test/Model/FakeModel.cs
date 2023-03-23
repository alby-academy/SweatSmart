namespace SweatSmart.Test.Model;

using Bogus;

public sealed class ProductFaker : Faker<Product>
{
    public ProductFaker()
    {
        RuleFor(o => o.Id, f => f.IndexFaker);
        RuleFor(o => o.Name, f => f.Commerce.Product());
        RuleFor(o => o.Price, f => f.Random.Decimal());
    }
}

public sealed class UserFaker : Faker<User>
{
    public UserFaker()
    {
        RuleFor(o => o.Id, f => f.IndexFaker);
        RuleFor(o => o.Email, f => f.Internet.Email());
        RuleFor(o => o.GivenName, f => f.Person.FirstName);
        RuleFor(o => o.FamilyName, f => f.Person.LastName);
    }
}

public class OrdersFaker : Faker<Order>
{
    public OrdersFaker(IEnumerable<Product> products, IEnumerable<User> users)
    {
        RuleFor(o => o.ProductId, f => f.PickRandom(products).Id);
        RuleFor(o => o.UserId, f => f.PickRandom(users).Id);
        RuleFor(o => o.Quantity, f => f.Random.Int(1, 10));
        RuleFor(o => o.OccuredOn, f => f.Date.PastOffset(5));
    }
}
