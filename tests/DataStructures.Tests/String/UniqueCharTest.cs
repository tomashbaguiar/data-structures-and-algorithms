using DataStructures.String;
using Xunit;

namespace DataStructures.Tests.String;

public class UniqueCharTest
{
    [Theory]
    [InlineData("leetcode", 0)]
    [InlineData("loveleetcode", 2)]
    [InlineData("aabb", -1)]
    public void First_Test(string s, int expected)
    {
        var result = UniqueChar.First(s);
        
        Assert.Equal(expected, result);
    }
}