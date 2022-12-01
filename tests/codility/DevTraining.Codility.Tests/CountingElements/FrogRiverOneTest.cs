using DevTraining.Codility.CountingElements;
using Xunit;

namespace DevTraining.Codility.Tests.CountingElements;

public class FrogRiverOneTest
{
    [Theory]
    [InlineData(new[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 5, 6)]
    [InlineData(new[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6, -1)]
    [InlineData(new[] { 1, 3, 2, 1, 3 }, 3, 2)]
    public void Solution_Test(int[] array, int x, int expected)
    {
        var result = FrogRiverOne.Solution(x, array);
        
        Assert.Equal(expected, result);
    }
}