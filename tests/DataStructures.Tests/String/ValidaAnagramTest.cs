using DataStructures.String;
using Xunit;

namespace DataStructures.Tests.String;

public class ValidaAnagramTest
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("ab", "a", false)]
    public void IsValidLinq_Test(string s, string t, bool expected)
    {
        var result = ValidaAnagram.IsValidLinq(s, t);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("ab", "a", false)]
    [InlineData("a", "ab", false)]
    public void IsValid_Test(string s, string t, bool expected)
    {
        var result = ValidaAnagram.IsValid(s, t);
        
        Assert.Equal(expected, result);
    }
}