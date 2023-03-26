namespace SweatSmart.UnitTest;

public static class DictionaryAssert
{
    public static void AreEqual<TKey, TValue>(Dictionary<TKey, ICollection<TValue>> expected, Dictionary<TKey, ICollection<TValue>> actual)
        where TKey : notnull
        => AreEqual(expected, actual, (a, b) => CollectionAssert.AreEqual(a.ToList(), b.ToList()));

    public static void AreEqual<TKey, TValue>(Dictionary<TKey, IEnumerable<TValue>> expected, Dictionary<TKey, IEnumerable<TValue>> actual)
        where TKey : notnull
        where TValue : IEquatable<TValue>
        => AreEqual(expected, actual, (a, b) => CollectionAssert.AreEqual(a.ToList(), b.ToList()));

    private static void AreEqual<TKey, TValue>(Dictionary<TKey, TValue> expected, IReadOnlyDictionary<TKey, TValue> actual, Action<TValue, TValue> assertEqual)
        where TKey : notnull
    {
        Assert.AreEqual(expected.Count, actual.Count, "The number of keys in the actual dictionary is not the same as in the expected dictionary.");

        foreach (var expectedKey in expected.Keys)
        {
            Assert.IsTrue(actual.ContainsKey(expectedKey), $"The actual dictionary does not contain the key {expectedKey}.");
            assertEqual(expected[expectedKey], actual[expectedKey]);
        }
    }
}