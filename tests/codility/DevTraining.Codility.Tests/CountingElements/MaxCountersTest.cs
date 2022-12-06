using DevTraining.Codility.CountingElements;
using Xunit;

namespace DevTraining.Codility.Tests.CountingElements;

public class MaxCountersTest
{
    [Theory]
    [InlineData(new[] { 3, 4, 4, 6, 1, 4, 4 }, 5, new[] { 3, 2, 2, 4, 2 })]
    public void Solution_Test(int[] array, int n, int[] expected)
    {
        var result = MaxCounters.Solution(array, n);
        
        Assert.Equal(expected, result);
    }
}