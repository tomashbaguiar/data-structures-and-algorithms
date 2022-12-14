using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class SubarraySumEqualsKTest
{
    [Theory]
    [InlineData(new[] { 1, 1, 1 }, 2, 2)]
    [InlineData(new[] { 1, 2, 3 }, 3, 2)]
    public void FindBruteForce_Test(int[] array, int k, int expected)
    {
        var result = SubarraySumEqualsK.FindBruteForce(array, k);
        
        Assert.Equal(expected, result);
    }
}