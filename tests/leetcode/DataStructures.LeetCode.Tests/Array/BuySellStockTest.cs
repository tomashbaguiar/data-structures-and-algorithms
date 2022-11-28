using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class BuySellStockTest
{
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new [] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitBruteForce_Test(int[] array, int expected)
    {
        var result = BuySellStock.MaxProfitBruteForce(array);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new [] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitDynamicProgramming_Test(int[] array, int expected)
    {
        var result = BuySellStock.MaxProfitDynamicProgramming(array);
        
        Assert.Equal(expected, result);
    }
}