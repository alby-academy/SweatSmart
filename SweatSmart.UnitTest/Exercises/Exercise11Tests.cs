namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise11Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise11();
        var actual = sut.Run().ToArray();

        string[] expected = { "apple", "orange", "grape", "pear", "grapefruit", "cherry", "banana", "kiwi" };

        CollectionAssert.AreEqual(expected, actual);
    }
}