using Xunit;

namespace RemoveTrailingZerosFromAString.Tests;

public class RemoveTrailingZerosFromAString
{
    [Theory]
    [InlineData("12300", "123")]
    [InlineData("00000", "")]
    [InlineData("123", "123")]
    public void RemoveOccurrences_IsExpected(string? s, string? expectedValue)
    {
        var result = new Solution().RemoveTrailingZeros(s);
        Assert.True(result == expectedValue);
    }
}