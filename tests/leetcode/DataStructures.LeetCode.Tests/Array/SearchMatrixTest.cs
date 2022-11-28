using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class SearchMatrixTest
{
    [Theory]
    [InlineData(true, 3, 
        new[] { 1, 3, 5, 7 }, 
        new[] { 10, 11, 16, 20 }, 
        new[] { 23, 30, 34, 60 })]
    [InlineData(false, 13, 
        new[] { 1, 3, 5, 7 }, 
        new[] { 10, 11, 16, 20 }, 
        new[] { 23, 30, 34, 60 })]
    [InlineData(false, 0, new[] { 1 })]
    [InlineData(true, 3, new[] { 1 }, new[] { 3 })]
    [InlineData(false, 0, new[] { 1, 1 })]
    [InlineData(false, 2, new[] { 1 })]
    [InlineData(false, 2, new[] { 1 }, new[] { 3 })]
    [InlineData(false, 0, new[] { 1 }, new[] { 3 })]
    [InlineData(true, 3, new[] { 1 }, new[] { 3 }, new[] { 5 })]
    [InlineData(true, 3, new[] { 1, 3 })]
    public void SearchBruteForce_Test(bool expected, int target, params int[][] matrix)
    {
        var result = SearchMatrix.SearchBruteForce(matrix, target);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(true, 3, 
        new[] { 1, 3, 5, 7 }, 
        new[] { 10, 11, 16, 20 }, 
        new[] { 23, 30, 34, 60 })]
    [InlineData(false, 13, 
        new[] { 1, 3, 5, 7 }, 
        new[] { 10, 11, 16, 20 }, 
        new[] { 23, 30, 34, 60 })]
    [InlineData(false, 0, new[] { 1 })]
    [InlineData(true, 3, new[] { 1 }, new[] { 3 })]
    [InlineData(false, 0, new[] { 1, 1 })]
    [InlineData(false, 2, new[] { 1 })]
    [InlineData(false, 2, new[] { 1 }, new[] { 3 })]
    [InlineData(false, 0, new[] { 1 }, new[] { 3 })]
    [InlineData(true, 3, new[] { 1 }, new[] { 3 }, new[] { 5 })]
    [InlineData(true, 3, new[] { 1, 3 })]
    public void BinarySearch_Test(bool expected, int target, params int[][] matrix)
    {
        var result = SearchMatrix.BinarySearch(matrix, target);
        
        Assert.Equal(expected, result);
    }
}