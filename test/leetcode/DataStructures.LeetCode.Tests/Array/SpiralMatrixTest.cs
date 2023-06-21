using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class SpiralMatrixTest
{
    [Fact]
    public void Generate_WhenNEqual1_ReturnsMatrixOf1()
    {
        const int n = 1;
        var expected = new[] { new[] { 1 } };

        var result = SpiralMatrix.Generate(n);
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Generate_WhenNEqual2_ReturnsSpiralMatrix()
    {
        const int n = 2;
        var expected = new[] { new[] { 1, 2 }, new[] { 4, 3 } };

        var result = SpiralMatrix.Generate(n);
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Generate_WhenNEqual3_ReturnsSpiralMatrix()
    {
        const int n = 3;
        var expected = new[] { new[] { 1, 2, 3 }, new[] { 8, 9, 4 }, new[] { 7, 6, 5 } };

        var result = SpiralMatrix.Generate(n);
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Generate_WhenNEqual4_ReturnsSpiralMatrix()
    {
        const int n = 4;
        var expected = new[]
        {
            new[] { 1, 2, 3, 4 }, new[] { 12, 13, 14, 5 }, new[] { 11, 16, 15, 6 }, new[] { 10, 9, 8, 7 }
        };

        var result = SpiralMatrix.Generate(n);
        
        Assert.Equal(expected, result);
    }
}