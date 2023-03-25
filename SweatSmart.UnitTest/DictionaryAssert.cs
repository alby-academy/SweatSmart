namespace SweatSmart.UnitTest;

public static class DictionaryAssert
{
    public static void AreEqual<TKey, TValue>(Dictionary<TKey, IEnumerable<TValue>> expected, Dictionary<TKey, IEnumerable<TValue>> actual)
        where TKey : notnull
        where TValue : IEquatable<TValue>
    {
        // Assert that actual and expected have the same number of keys
        Assert.AreEqual(expected.Count, actual.Count, "The number of keys in the actual dictionary is not the same as in the expected dictionary.");

        // For each key in expected, verify that actual contains the same key and that the values are equivalent
        foreach (var expectedKey in expected.Keys)
        {
            Assert.IsTrue(actual.ContainsKey(expectedKey), $"The actual dictionary does not contain the key {expectedKey}.");
            CollectionAssert.AreEqual(expected[expectedKey].ToList(), actual[expectedKey].ToList(), $"The actual value for key {expectedKey} does not match the expected value.");
        }
    }

    public static void AreEqual<TKey, TValue>(Dictionary<TKey, ICollection<TValue>> expected, Dictionary<TKey, ICollection<TValue>> actual)
        where TKey : notnull
    {
        // Assert that actual and expected have the same number of keys
        Assert.AreEqual(expected.Count, actual.Count, "The number of keys in the actual dictionary is not the same as in the expected dictionary.");

        // For each key in expected, verify that actual contains the same key and that the values are equivalent
        foreach (var expectedKey in expected.Keys)
        {
            Assert.IsTrue(actual.ContainsKey(expectedKey), $"The actual dictionary does not contain the key {expectedKey}.");
            CollectionAssert.AreEqual(expected[expectedKey].ToList(), actual[expectedKey].ToList(), $"The actual value for key {expectedKey} does not match the expected value.");
        }
    }
}