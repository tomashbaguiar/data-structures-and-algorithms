using DataStructures.Array;
using Xunit;

namespace DataStructures.Tests.Array;

public class ReshapeMatrixTest
{
    [Fact]
    public void Reshape_WhenRIs1_AndCIs4()
    {
        var matrix = new[] { new [] { 1, 2 }, new [] { 3, 4 } };
        const int c = 4;
        const int r = 1;
        var expected = new[] { new[] { 1, 2, 3, 4 } };

        var result = ReshapeMatrix.Reshape(matrix, r, c);
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Reshape_WhenRIs2_AndCIs4()
    {
        var matrix = new[] { new [] { 1, 2 }, new [] { 3, 4 } };
        const int c = 4;
        const int r = 2;

        var result = ReshapeMatrix.Reshape(matrix, r, c);
        
        Assert.Equal(matrix, result);
    }
}