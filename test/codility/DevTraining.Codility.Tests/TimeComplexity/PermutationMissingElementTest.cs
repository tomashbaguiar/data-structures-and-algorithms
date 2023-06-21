using DevTraining.Codility.TimeComplexity;
using Xunit;

namespace DevTraining.Codility.Tests.TimeComplexity;

public class PermutationMissingElementTest
{
    [Theory]
    [InlineData(new[] { 2, 3, 1, 5 }, 4)]
    [InlineData(new[] { 2, 4, 1, 5 }, 3)]
    [InlineData(new int[] { }, 1)]
    [InlineData(new[] { 2 }, 1)]
    public void Solution_Test(int[] array, int expected)
    {
        var result = PermutationMissingElement.Solution(array);
        
        Assert.Equal(expected, result);
    }
}