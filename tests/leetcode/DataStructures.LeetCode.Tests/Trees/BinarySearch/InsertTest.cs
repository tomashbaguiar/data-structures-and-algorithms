using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.Binary.Traversal.BreadthFirst;
using Xunit;
using Tree = DataStructures.LeetCode.Trees.BinarySearch.Tree;

namespace DataStructures.LeetCode.Tests.Trees.BinarySearch;

public class InsertTest
{
    [Theory]
    [InlineData(new[] { 4, 2, 7, 1, 3 }, 5, new[] { 4, 2, 7, 1, 3, 5 })]
    [InlineData(new[] { 40, 20, 60, 10, 30, 50, 70 }, 25, new[] { 40, 20, 60, 10, 30, 50, 70, 25 })]
    public void Insert_Test(int[] tree, int val, int[] expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        Tree.Insert(root, val);
        var result = LevelOrder.Traversal(root).SelectMany(l => l).ToArray();
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 4, 2, 7, 1, 3 }, 5, new[] { 4, 2, 7, 1, 3, 5 })]
    [InlineData(new[] { 40, 20, 60, 10, 30, 50, 70 }, 25, new[] { 40, 20, 60, 10, 30, 50, 70, 25 })]
    public void InsertIterative_Test(int[] tree, int val, int[] expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.InsertIterative);

        Tree.InsertIterative(root, val);
        var result = LevelOrder.Traversal(root).SelectMany(l => l).ToArray();
        
        Assert.Equal(expected, result);
    }
}