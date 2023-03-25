namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise03Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise3();
        var actual = sut.Run().ToArray();

        int[] expected = { 0, 9, 45 };

        CollectionAssert.AreEqual(expected, actual);
    }
}