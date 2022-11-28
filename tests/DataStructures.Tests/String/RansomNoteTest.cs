using DataStructures.String;
using Xunit;

namespace DataStructures.Tests.String;

public class RansomNoteTest
{
    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    public void CanConstruct_Test(string ransomNote, string magazine, bool expected)
    {
        var result = RansomNote.CanConstruct(ransomNote, magazine);
        
        Assert.Equal(expected, result);
    }
}