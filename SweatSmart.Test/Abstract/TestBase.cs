namespace SweatSmart.Test.Abstract;

using Model;

public abstract class TestBase : ITest
{
    protected readonly IWriter Writer;
    protected readonly IEnumerable<Product> Products;
    protected readonly IEnumerable<User> Users;
    protected readonly IEnumerable<Order> Orders;

    protected TestBase(IWriter writer, Func<IEnumerable<Product>> products, Func<IEnumerable<User>> users, Func<IEnumerable<Product>, IEnumerable<User>, IEnumerable<Order>> orders)
    {
        Writer = writer;
        Products = products();
        Users = users();
        Orders = orders(Products, Users);
    }

    public abstract void Run();
    
    public void Write()
    {
        Writer.WriteProducts(Products);
        Writer.WriteUsers(Users);
        Writer.WriteOrders(Orders);
    }
}