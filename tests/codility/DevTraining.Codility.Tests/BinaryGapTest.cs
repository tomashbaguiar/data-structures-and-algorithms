using Xunit;

namespace DevTraining.Codility.Tests;

public class BinaryGapTest
{
    [Theory]
    [InlineData(2, 0)]
    [InlineData(9, 2)]
    [InlineData(1162, 3)]
    [InlineData(51712, 2)]
    public void Solution_Test(int n, int expected)
    {
        var result = BinaryGap.Solution(n);
        
        Assert.Equal(expected, result);
    }
}