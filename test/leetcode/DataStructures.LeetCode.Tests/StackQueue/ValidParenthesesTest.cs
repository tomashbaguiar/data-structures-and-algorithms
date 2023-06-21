using DataStructures.LeetCode.StackQueue;
using Xunit;

namespace DataStructures.LeetCode.Tests.StackQueue;

public class ValidParenthesesTest
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("", true)]
    [InlineData("]", false)]
    [InlineData("[", false)]
    [InlineData("(])", false)]
    public void IsValid_Test(string s, bool expected)
    {
        var result = ValidParentheses.IsValid(s);
        
        Assert.Equal(expected, result);
    }
}