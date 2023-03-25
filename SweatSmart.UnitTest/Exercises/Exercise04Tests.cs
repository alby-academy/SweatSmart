namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise04Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise4();
        var actual = sut.Run().ToArray();

        int[] expected = { 2, 4, 6, 8, 10 };

        CollectionAssert.AreEqual(expected, actual);
    }
}