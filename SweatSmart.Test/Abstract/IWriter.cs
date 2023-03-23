namespace SweatSmart.Test.Abstract;

using Model;

public interface IWriter
{
    void WriteProducts(IEnumerable<Product> products);
    void WriteUsers(IEnumerable<User> users);
    void WriteOrders(IEnumerable<Order> orders);
}