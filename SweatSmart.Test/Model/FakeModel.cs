namespace SweatSmart.Test.Model;

using Bogus;

public sealed class ProductFaker : Faker<Product>
{
    public ProductFaker()
    {
        CustomInstantiator(f =>
        {
            var id = f.IndexFaker;
            var name = f.Commerce.Product();
            var price = f.Random.Decimal(10M);
            return new(id, name, price);
        });
    }
}

public sealed class UserFaker : Faker<User>
{
    public UserFaker()
    {
        CustomInstantiator(f =>
        {
            var id = f.IndexFaker;
            var email = f.Internet.Email();
            var givenName = f.Person.FirstName;
            var familyName = f.Person.LastName;

            return new(id, email, givenName, familyName);
        });
    }
}

public class OrdersFaker : Faker<Order>
{
    public OrdersFaker(IEnumerable<Product> products, IEnumerable<User> users)
    {
        CustomInstantiator(f =>
        {
            var productId = f.PickRandom(products).Id;
            var userId = f.PickRandom(users).Id;
            var quantity = f.Random.Int(1, 10);
            var occuredOn = f.Date.Past(5);

            return new(productId, userId, quantity, occuredOn);
        });
    }
}