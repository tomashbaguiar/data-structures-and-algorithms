using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using Xunit;

namespace DataStructures.LeetCode.Tests.Trees.Binary;

public class PathSumTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 5, false)]
    [InlineData(new[] { 5, 4, 8, 11, 13, 4, 7, 2, 1 }, 22, true)]
    public void HasPathSum_Test(int[] tree, int target, bool expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var result = PathSum.HasPathSum(root, target);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 5, false)]
    [InlineData(new[] { 5, 4, 8, 11, 13, 4, 7, 2, 1 }, 22, true)]
    public void HasPathSumIterative_Test(int[] tree, int target, bool expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var result = PathSum.HasPathSumIterative(root, target);
        
        Assert.Equal(expected, result);
    }
}