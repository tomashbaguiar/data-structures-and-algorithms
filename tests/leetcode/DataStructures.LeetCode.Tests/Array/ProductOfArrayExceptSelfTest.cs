using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class ProductOfArrayExceptSelfTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    public void Calculate_Test(int[] array, int[] expected)
    {
        var result = ProductOfArrayExceptSelf.Calculate(array);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    public void CalculateLessSpace_Test(int[] array, int[] expected)
    {
        var result = ProductOfArrayExceptSelf.Calculate_LessSpace(array);
        
        Assert.Equal(expected, result);
    }
}