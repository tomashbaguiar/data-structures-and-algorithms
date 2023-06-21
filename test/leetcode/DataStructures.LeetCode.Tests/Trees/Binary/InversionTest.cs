using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.Binary.Traversal.BreadthFirst;
using Xunit;

namespace DataStructures.LeetCode.Tests.Trees.Binary;

public class InversionTest
{
    [Theory]
    [InlineData(new[] { 4, 2, 7, 1, 3, 6, 9 }, new[] { 4, 7, 2, 9, 6, 3, 1 })]
    public void Invert_Test(int[] tree, int[] expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var invRoot = Inversion.Invert(root);
        var result = LevelOrder.Traversal(invRoot).SelectMany(l => l).ToList();
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 4, 2, 7, 1, 3, 6, 9 }, new[] { 4, 7, 2, 9, 6, 3, 1 })]
    public void InvertIterative_Test(int[] tree, int[] expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var invRoot = Inversion.InvertIterative(root);
        var result = LevelOrder.Traversal(invRoot).SelectMany(l => l).ToList();
        
        Assert.Equal(expected, result);
    }
}