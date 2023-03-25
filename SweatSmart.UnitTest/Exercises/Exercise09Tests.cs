namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise09Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise9();
        var result = sut.Run().ToArray();


        var firstObj = result.First();
        var length1 = (int)(firstObj.GetType().GetProperty("Length")?.GetValue(firstObj) ?? throw new InvalidCastException("Cannot cast lenght property"));
        var word1 = (string)firstObj.GetType().GetProperty("Word")?.GetValue(firstObj)!;

        var lastObj = result.Last();
        var length2 = (int)(lastObj.GetType().GetProperty("Length")?.GetValue(lastObj) ?? throw new InvalidCastException("Cannot cast lenght property"));
        var word2 = (string)lastObj.GetType().GetProperty("Word")?.GetValue(lastObj)!;

        object[] actual =
        {
            new
            {
                Length = length1,
                Word = word1
            },
            new
            {
                Length = length2,
                Word = word2
            }
        };

        object[] expected =
        {
            new { Length = 6, Word = "banana" },
            new { Length = 4, Word = "pear" }
        };

        CollectionAssert.AreEqual(expected, actual);
    }
}