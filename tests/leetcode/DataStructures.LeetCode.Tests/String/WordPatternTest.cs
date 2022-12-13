using DataStructures.LeetCode.String;
using Xunit;

namespace DataStructures.LeetCode.Tests.String;

public class WordPatternTest
{
    [Theory]
    [InlineData("abba", "dog cat cat dog", true)]
    [InlineData("abba", "dog cat cat fish", false)]
    [InlineData("aaaa", "dog cat cat dog", false)]
    [InlineData("aaa", "dog cat cat dog", false)]
    [InlineData("abba", "dog dog dog dog", false)]
    public void Match_Test(string pattern, string s, bool expected)
    {
        var result = WordPattern.Match(pattern, s);
        
        Assert.Equal(expected, result);
    }
}