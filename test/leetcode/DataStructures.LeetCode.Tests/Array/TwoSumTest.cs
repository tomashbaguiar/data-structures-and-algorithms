using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class TwoSumTest
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new [] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new [] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSumBruteForce_Test(int[] array, int target, int[] expected)
    {
        var result = TwoSum.TwoSumBruteForce(array, target);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new [] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new [] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSumHashTable_Test(int[] array, int target, int[] expected)
    {
        var result = TwoSum.TwoSumHashTable(array, target);
        
        Assert.Equal(expected, result);
    }
}