namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise07Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise7();
        var actual = sut.Run().ToArray();

        int[] expected = { 9, 16, 25 };

        CollectionAssert.AreEqual(expected, actual);
    }
}