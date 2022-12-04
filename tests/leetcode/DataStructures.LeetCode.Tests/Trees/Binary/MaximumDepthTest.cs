using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using Xunit;

namespace DataStructures.LeetCode.Tests.Trees.Binary;

public class MaximumDepthTest
{
    [Theory]
    [InlineData(new[] { 3, 9, 20, 15, 7 }, 3)]
    public void Get(int[] tree, int expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);
        
        var result = MaximumDepth.Get(root);
        
        Assert.Equal(expected, result);
    }
}