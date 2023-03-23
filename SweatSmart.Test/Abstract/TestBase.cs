namespace SweatSmart.Test.Abstract;

using Model;

public abstract class TestBase : ITest
{
    protected readonly IEnumerable<Order> Orders;
    protected readonly IEnumerable<Product> Products;
    protected readonly IEnumerable<User> Users;
    protected readonly IWriter Writer;

    protected TestBase(IWriter writer, int products, int users, int orders)
    {
        Writer = writer;
        Products = new ProductFaker().Generate(products);
        Users = new UserFaker().Generate(users);
        Orders = new OrdersFaker(Products, Users).Generate(orders);
    }

    public abstract void Run();

    public void Write()
    {
        Writer.WriteProducts(Products);
        Writer.WriteUsers(Users);
        Writer.WriteOrders(Orders);
    }
}