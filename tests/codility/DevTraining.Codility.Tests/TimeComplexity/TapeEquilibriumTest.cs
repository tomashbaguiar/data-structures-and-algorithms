using DevTraining.Codility.TimeComplexity;
using Xunit;

namespace DevTraining.Codility.Tests.TimeComplexity;

public class TapeEquilibriumTest
{
    [Theory]
    [InlineData(new[] { 3, 1, 2, 4, 3 }, 1)]
    public void Solution_Test(int[] array, int expected)
    {
        var result = TapeEquilibrium.Solution(array);
        
        Assert.Equal(expected, result);
    }
}