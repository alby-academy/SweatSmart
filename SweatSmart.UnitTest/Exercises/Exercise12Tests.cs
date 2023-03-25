namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise12Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise12();
        var actual = sut.Run().ToArray();

        int[] expected = { 467, 1936, 1959, 4958, 4059, 4991, 1665, 1886 };

        CollectionAssert.AreEqual(expected, actual);
    }
}