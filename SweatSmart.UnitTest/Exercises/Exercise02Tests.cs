namespace SweatSmart.UnitTest.Exercises;

using Model;
using SweatSmart.Exercises;

[TestClass]
public class Exercise02Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise2();
        var actual = sut.Run();

        var expected = new Dictionary<string, ICollection<City>>
        {
            {
                "italy",
                new City[]
                {
                    new("Rome", 2860009),
                    new("Milan", 1371498)
                }
            },
            {
                "england",
                new City[]
                {
                    new("London", 8799800),
                    new("Birmingham", 1144919)
                }
            },
            {
                "usa",
                new City[]
                {
                    new("Los Angles", 3898747),
                    new("New York", 8804190),
                    new("Dallas", 1304379),
                    new("Chicago", 2746388)
                }
            },
            {
                "spain",
                new City[]
                {
                    new("Madrid", 3223334),
                    new("Barcelona", 1620343)
                }
            }
        };

        DictionaryAssert.AreEqual(expected, actual);
    }
}