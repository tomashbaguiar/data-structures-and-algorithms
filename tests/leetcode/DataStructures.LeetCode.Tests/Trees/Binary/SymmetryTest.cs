using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using Xunit;

namespace DataStructures.LeetCode.Tests.Trees.Binary;

public class SymmetryTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 2, 3, 4, 4, 3 }, true)]
    [InlineData(new [] { 1, 2, 2, 3, 3 }, false)]
    public void IsSymmetric_Test(int[] tree, bool expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var result = Symmetry.IsSymmetric(root);
        
        Assert.Equal(expected, result);
    }
}