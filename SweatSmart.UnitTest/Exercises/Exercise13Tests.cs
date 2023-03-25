namespace SweatSmart.UnitTest.Exercises;

using System.Collections;
using SweatSmart.Exercises;

[TestClass]
public class Exercise13Tests
{
    [TestMethod]
    public void Correct()
    {
        var sut = new Exercise13();
        var actual = sut.Run().ToArray();

        object[] expected =
        {
            new { Category = "Category3", Price = 30m },
            new { Category = "Category2", Price = 20m },
            new { Category = "Category1", Price = 15m }
        };

        CollectionAssert.AreEqual(expected, actual, new ObjectComparer());
    }

    private class ObjectComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var xProps = x.GetType().GetProperties();
            var yProps = y.GetType().GetProperties();

            if (xProps.Length != yProps.Length) return -1;

            foreach (var propX in xProps)
            {
                var propY = y.GetType().GetProperty(propX.Name);
                if (propY is null) return -1;

                var valX = propX.GetValue(x, null);
                var valY = propY.GetValue(y, null);
                if (!valX?.Equals(valY) ?? true) return -1;
            }

            return 0;
        }
    }
}