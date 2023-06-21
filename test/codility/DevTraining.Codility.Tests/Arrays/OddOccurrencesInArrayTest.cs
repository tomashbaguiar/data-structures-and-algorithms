using DevTraining.Codility.Arrays;
using Xunit;

namespace DevTraining.Codility.Tests.Arrays;

public class OddOccurrencesInArrayTest
{
    [Theory]
    [InlineData(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
    public void Solution_Test(int[] array, int expected)
    {
        var result = OddOccurrencesInArray.Solution(array);
        
        Assert.Equal(expected, result);
    }
}