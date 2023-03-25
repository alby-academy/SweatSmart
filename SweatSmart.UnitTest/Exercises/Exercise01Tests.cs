namespace SweatSmart.UnitTest.Exercises;

using Model;
using SweatSmart.Exercises;

[TestClass]
public class Exercise01Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise1();
        var actual = sut.Run().ToArray();

        Person[] expected =
        {
            new("Paolo", "Ferrari", "paolo.rossi@email.it", 31),
            new("Giuseppe", "Lamborghini", "giuseppe.verdi@email.it", 76),
            new("Marco", "Maserati", "marco.blu@email.it", 28),
            new("Luigi", "Bianchi", "luigi.bianchi@email.it", 34),
            new("Paolo", "Rossi", "paolo.rossi@email.it", 31)
        };

        CollectionAssert.AreEquivalent(expected, actual);
    }
}