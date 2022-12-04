using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.Binary.Traversal;
using Xunit;

namespace DataStructures.LeetCode.Tests.Trees.Binary.Traversal;

public class LevelOrderTest
{
    [Theory]
    [InlineData(new[] { 3, 9, 20, 15, 7 }, new[] { 3 }, new[] { 9 }, new[] { 7, 20 }, new[] { 15 })]
    public void TraversalIterative_Test(int[] listTree, params int[][] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, Tree.Add);

        var result = LevelOrder.TraversalIterative(root);
        
        Assert.Equal(expected.Select(p => p.ToList()).ToList(), result);
    }
    
    [Theory]
    [InlineData(new[] { 3, 9, 20, 15, 7 }, new[] { 3 }, new[] { 9 }, new[] { 7, 20 }, new[] { 15 })]
    public void Traversal_Test(int[] listTree, params int[][] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, Tree.Add);

        var result = LevelOrder.Traversal(root);
        
        Assert.Equal(expected.Select(p => p.ToList()).ToList(), result);
    }
}