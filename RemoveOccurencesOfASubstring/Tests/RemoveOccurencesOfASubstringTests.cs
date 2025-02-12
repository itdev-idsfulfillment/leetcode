using Xunit;

namespace RemoveOccurencesOfASubstring.Tests;

public class RemoveOccurencesOfASubstringTests
{
    [Theory]
    [InlineData("daabcbaabcbc", "abc", "dab")]
    [InlineData("axxxxyyyyb", "xy", "ab")]
    [InlineData("aaaaaaaaa", "a", "")]
    public void RemoveOccurrences_IsExpected(string? s, string? part, string? expectedValue)
    {
        var result = new Solution().RemoveOccurrences(s, part);
        Assert.True(result == expectedValue);
    }

    [Theory]
    [InlineData("abc", null, "abc")]
    [InlineData("abc", "", "abc")]
    [InlineData("abc", "xy", "abc")]
    public void RemoveOcurrences_ShouldNotRemove(string? s, string? part, string? expectedValue)
    {
        var result = new Solution().RemoveOccurrences(s, part);
        Assert.True(result == expectedValue);
    }

    [Theory]
    [InlineData(null, null, null)]
    [InlineData(null, "abc", null)]
    [InlineData("abc", null, "abc")]
    public void RemoveOccurrences_Nulls(string? s, string? part, string? expectedValue)
    {
        var result = new Solution().RemoveOccurrences(s, part);
        Assert.True(result == expectedValue);
    }
}