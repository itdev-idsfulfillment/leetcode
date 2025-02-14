using Xunit;

namespace RemoveTrailingZerosFromAString.Tests;

public class RemoveTrailingZerosFromAString
{
    [Theory]
    [InlineData("00000", "")]
    [InlineData("12345", "12345")]
    [InlineData("123000000000000000000000000000000000000000", "123")]
    public void RemoveOccurrences_IsExpected(string? s, string? expectedValue)
    {
        var result = new Solution().RemoveTrailingZeros(s);
        Assert.True(result == expectedValue);
    }
}