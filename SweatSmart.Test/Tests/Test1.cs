namespace SweatSmart.Test.Tests;

using Abstract;

/// <summary>
///     Write a query that, given a User, writes an Excel file containing:
///         1) User's Id, First Name, Last Name, and Email
///         2) Order Id
///         3) Comma-separated Product Ids in the Order
///         4) Total cost of the Order
///     If a User has no orders, the output should be as follows:
///         1) User's Id, First Name, Last Name, and Email
///         2) Order Id = 0
///         3) empty string
///         4) Cost should be 0
/// </summary>
public class Test1 : TestBase
{
    public Test1(IWriter writer) : base(writer, 10, 100, 100)
    {
    }

    public override void Run()
    {
    }
}