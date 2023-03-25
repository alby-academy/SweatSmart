namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise14Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise14();
        var actual = sut.Run().ToArray();

        string[] expected = { "apple", "None", "entertainment", "24", "No" };

        CollectionAssert.AreEqual(expected, actual);
    }
}