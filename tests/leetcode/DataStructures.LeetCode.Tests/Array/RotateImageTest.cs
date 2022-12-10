using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class RotateImageTest
{
    [Fact]
    public void Rotate_Test()
    {
        var matrix = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
        var expected = new[] { new[] { 7, 4, 1 }, new[] { 8, 5, 2 }, new[] { 9, 6, 3 } };

        RotateImage.Rotate(matrix);
        
        Assert.Equal(expected, matrix);
    }

    [Fact]
    public void Rotate_Test_Big()
    {
        var matrix = new[] { 
            new[] { 5, 1, 9, 11 }, 
            new[] { 2, 4, 8, 10 }, 
            new[] { 13, 3, 6, 7 }, 
            new[] { 15, 14, 12, 16 } 
        };
        var expected = new[] { 
            new[] { 15, 13, 2, 5 }, 
            new[] { 14, 3, 4, 1 }, 
            new[] { 12, 6, 8, 9 }, 
            new[] { 16, 7, 10, 11 } 
        };
        
        RotateImage.Rotate(matrix);
        
        Assert.Equal(expected, matrix);
    }
}