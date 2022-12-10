using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class Search2dMatrixTest
{
    [Theory]
    [InlineData(5, true,
        new[] { 1, 4, 7, 11, 15 },
        new[] { 2, 5, 8, 12, 19 },
        new[] { 3, 6, 9, 16, 22 },
        new[] { 10, 13, 14, 17, 24 },
        new[] { 18, 21, 23, 26, 30 })]
    public void Search_Test(int target, bool expected, params int[][] matrix)
    {
        var result = Search2dMatrix.BinarySearch(matrix, target);
        
        Assert.Equal(expected, result);
    }
}