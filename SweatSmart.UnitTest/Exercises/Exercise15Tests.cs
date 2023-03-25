namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise15Tests
{
    [TestMethod]
    public void Exercise15RunTest()
    {
        var sut = new Exercise15();
        var actual = sut.Run();

        var expected = new Dictionary<string, IEnumerable<int>>
        {
            { "Even", new List<int> { 2, 4, 6, 8, 10 } },
            { "Odd", new List<int> { 1, 3, 5, 7, 9 } }
        };

        DictionaryAssert.AreEqual(expected, actual);
    }
}