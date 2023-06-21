using DevTraining.Codility.CountingElements;
using Xunit;

namespace DevTraining.Codility.Tests.CountingElements;

public class PermutationCheckTest
{
    [Theory]
    [InlineData(new[] { 4, 1, 3, 2 }, 1)]
    [InlineData(new[] { 4, 1, 3 }, 0)]
    [InlineData(new[] { 2, 3, 4, 5 }, 0)]
    public void Solution_Test(int[] array, int expected)
    {
        var result = PermutationCheck.Solution(array);
        
        Assert.Equal(expected, result);
    }
}