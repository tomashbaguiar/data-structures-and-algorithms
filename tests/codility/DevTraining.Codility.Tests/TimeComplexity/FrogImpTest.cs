using DevTraining.Codility.TimeComplexity;
using Xunit;

namespace DevTraining.Codility.Tests.TimeComplexity;

public class FrogImpTest
{
    [Theory]
    [InlineData(10, 85, 30, 3)]
    [InlineData(10, 100, 30, 3)]
    public void Solution_Test(int x, int y, int d, int expected)
    {
        var result = FrogImp.Solution(x, y, d);
        
        Assert.Equal(expected, result);
    }
}