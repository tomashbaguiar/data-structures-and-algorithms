using System.Linq;
using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class ThreeSumTest
{
    [Theory]
    [InlineData(new[] { -1, 0, 1, 2, -1, -4 }, new[] { -1, -1, 2 }, new[] { -1, 0, 1 })]
    [InlineData(new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0 })]
    public void Solution_Test(int[] array, params int[][] expected)
    {
        var result = ThreeSum.Solution(array)
            .Select(l => l.ToArray())
            .ToArray();
        
        Assert.Equal(expected, result);
    }
}