using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class SingleElementTest
{
    [Theory]
    [InlineData(new[] { 2, 2, 1 }, 1)]
    [InlineData(new[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new[] { 1 }, 1)]
    public void Find_Test(int[] array, int expected)
    {
        var result = SingleElement.Find(array);
        
        Assert.Equal(expected, result);
    }
}