using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class SubarraySumEqualsKTest
{
    [Theory]
    [InlineData(new[] { 1, 1, 1 }, 2, 2)]
    [InlineData(new[] { 1, 2, 3 }, 3, 2)]
    [InlineData(new[] { -1, -1, 1 }, 0, 1)]
    public void Find_Test(int[] array, int k, int expected)
    {
        var result = SubarraySumEqualsK.Find(array, k);
        
        Assert.Equal(expected, result);
    }
}