using System.Linq;
using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class PascalsTriangleIiTest
{
    [Theory]
    [InlineData(3, new[] { 1, 3, 3, 1 })]
    public void Generate_WithNumRows5(int rowIndex, int[] expected)
    {
        var result = PascalsTriangleIi.GetRow(rowIndex);
        
        Assert.Equal(expected.ToList(), result);
    }
}