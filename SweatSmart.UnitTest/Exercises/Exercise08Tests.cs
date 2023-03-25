namespace SweatSmart.UnitTest.Exercises;

using Model;
using SweatSmart.Exercises;

[TestClass]
public class Exercise08Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise8();
        var actual = sut.Run().ToArray();

        Product[] expected =
        {
            new("Product A", 125),
            new("Product F", 105)
        };

        CollectionAssert.AreEqual(expected, actual);
    }
}