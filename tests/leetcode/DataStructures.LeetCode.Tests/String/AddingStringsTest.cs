using DataStructures.LeetCode.String;
using Xunit;

namespace DataStructures.LeetCode.Tests.String;

public class AddingStringsTest
{
    [Theory]
    [InlineData("11", "123", "134")]
    [InlineData("1", "9", "10")]
    [InlineData("6913259244", "71103343", "6984362587")]
    public void Add_Test(string num1, string num2, string expected)
    {
        var result = AddingStrings.Add(num1, num2);
        
        Assert.Equal(expected, result);
    }
}