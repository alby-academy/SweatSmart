namespace SweatSmart.Test.Tests;

using Abstract;

/// <summary>
///     Write a query that given a product returns:
///         1) Id, Name, and Price of the product
///         2) Ids of the users who have purchased that product separated by ","
///         3) The total number of times the product has been sold
///     If a product has no orders, it should be displayed as follows:
///         1) Id, Name, and Price of the product
///         2) an empty string
///         3) 0
/// </summary>
public class Test2 : TestBase
{
    public Test2(IWriter writer) : base(writer, 100, 10, 50)
    {
    }

    public override void Run()
    {
        Write();
    }
}