namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise10Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise10();
        var actual = sut.Run().ToArray();

        double[] expected = { 35D, 72D };

        CollectionAssert.AreEqual(expected, actual);
    }
}