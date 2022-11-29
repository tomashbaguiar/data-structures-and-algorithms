using Xunit;

namespace DevTraining.Codility.Tests;

public class CyclicRotationTest
{
    [Theory]
    [InlineData(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 })]
    [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
    [InlineData(new int[] { }, 1, new int[] { })]
    public void Solution_Test(int[] array, int k, int[] expected)
    {
        var result = CyclicRotation.Solution(array, k);
        
        Assert.Equal(expected, result);
    }
}