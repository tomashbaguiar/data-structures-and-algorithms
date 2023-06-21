using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class MajorityElementTest
{
    [Theory]
    [InlineData(new[] { 3, 2, 3 }, 3)]
    [InlineData(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void Find_Test(int[] array, int expected)
    {
        var result = MajorityElement.Find(array);
        
        Assert.Equal(expected, result);
    }
}