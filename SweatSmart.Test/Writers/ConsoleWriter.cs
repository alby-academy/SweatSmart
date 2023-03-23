namespace SweatSmart.Test.Writers;

using Abstract;

using Model;

public class ConsoleWriter : IWriter
{
    public void WriteProducts(IEnumerable<Product> products)
    {
        foreach (var product in products) Console.WriteLine("Id: {0} Name: {1} Price: {2:C0}", product.Id, product.Name, product.Price);
    }

    public void WriteUsers(IEnumerable<User> users)
    {
        foreach (var user in users) Console.WriteLine("Id: {0} GivenName: {1} FamilyName: {2} Email: {3}", user.Id, user.GivenName, user.FamilyName, user.Email);
    }

    public void WriteOrders(IEnumerable<Order> orders)
    {
        foreach (var order in orders) Console.WriteLine("Product: {0} User: {1} Quantity: {2} OccuredOn: {3}", order.ProductId, order.UserId, order.Quantity, order.OccuredOn.ToString());
    }
}