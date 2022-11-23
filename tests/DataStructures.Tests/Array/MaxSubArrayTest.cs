using DataStructures.Array;
using Xunit;

namespace DataStructures.Tests.Array;

public class MaxSubArrayTest
{
    [Theory]
    [InlineData(new [] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    [InlineData(new[] { 1, 2, 3, -3 }, 6)]
    [InlineData(new [] { 5, 4, -1, 7, 8 }, 23)]
    [InlineData(new [] { 1 }, 1)]
    public void Resolve_Test(int[] array, int expected)
    {
        var result = MaxSubArray.ResolveDivideAndConquer(array);
        
        Assert.Equal(expected, result);
    }
}