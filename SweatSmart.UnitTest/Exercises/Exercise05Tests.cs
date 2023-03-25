namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise05Tests
{
    /// <summary>
    ///     This test fails because the fix to the method under test is missing, since the exercise is to find the error.
    /// </summary>
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise5();
        var actual = sut.Run().ToArray();

        int[] expected = { 2, 4 };

        CollectionAssert.AreEqual(expected, actual);
    }
}