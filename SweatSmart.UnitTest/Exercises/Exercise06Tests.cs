namespace SweatSmart.UnitTest.Exercises;

using SweatSmart.Exercises;

[TestClass]
public class Exercise06Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise06();
        var result = sut.Run().SingleOrDefault();
        var actual = new
        {
            Name = result?.GetType().GetProperty("Name")?.GetValue(result) as string,
            Math = (int)(result?.GetType().GetProperty("Math")?.GetValue(result) ?? throw new InvalidCastException("Math cannot be converted to int")),
            Science = (int)(result.GetType().GetProperty("Science")?.GetValue(result) ?? throw new InvalidCastException("Science cannot be converted to int"))
        };

        var expected = new { Name = "Luigi Bianchi", Math = 9, Science = 10 };

        Assert.AreEqual(expected.Name, actual.Name);
        Assert.AreEqual(expected.Math, actual.Math);
        Assert.AreEqual(expected.Science, actual.Science);
    }
}