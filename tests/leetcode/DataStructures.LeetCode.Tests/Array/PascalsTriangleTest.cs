using System.Collections.Generic;
using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class PascalsTriangleTest
{
    [Fact]
    public void Generate_WithNumRows5()
    {
        const int numRows = 5;
        var expected = new List<IList<int>>
        {
            new List<int> { 1 }, 
            new List<int> { 1, 1 }, 
            new List<int> { 1, 2, 1 },
            new List<int> { 1, 3, 3, 1 }, 
            new List<int> { 1, 4, 6, 4, 1 },
        };
        
        var result = PascalsTriangle.Generate(numRows);
        
        Assert.Equal(expected, result);
    }
}