using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using Xunit;

namespace DataStructures.LeetCode.Tests.Trees.Binary;

public class MaximumDepthTest
{
    [Theory]
    [InlineData(new[] { 3, 9, 20, 15, 7 }, 3)]
    public void DepthFirstGet_Test(int[] tree, int expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);
        
        var result = MaximumDepth.DepthFirstGet(root);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 3, 9, 20, 15, 7 }, 3)]
    [InlineData(new[] { 1, 2 }, 2)]
    public void BreadthFirstGet_Test(int[] tree, int expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);
        
        var result = MaximumDepth.BreadthFirstGet(root);
        
        Assert.Equal(expected, result);
    }
}