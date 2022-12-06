using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.Binary.Traversal.BreadthFirst;
using DataStructures.LeetCode.Trees.BinarySearch;
using Xunit;
using Tree = DataStructures.LeetCode.Trees.BinarySearch.Tree;

namespace DataStructures.LeetCode.Tests.Trees.BinarySearch;

public class SearchTest
{
    [Theory]
    [InlineData(new[] { 4, 2, 7, 1, 3 }, 2, new[] { 2, 1, 3 })]
    [InlineData(new[] { 4, 2, 7, 1, 3 }, 5, new int[] {})]
    public void SearchBreadthFirst_Test(int[] tree, int target, int[] expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var resRoot = Search.SearchBreadthFirst(root, target);
        var result = LevelOrder.Traversal(resRoot).SelectMany(l => l).ToArray();
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 4, 2, 7, 1, 3 }, 2, new[] { 2, 1, 3 })]
    [InlineData(new[] { 4, 2, 7, 1, 3 }, 5, new int[] {})]
    public void SearchBreadthFirstIterative_Test(int[] tree, int target, int[] expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var resRoot = Search.SearchBreadthFirstIterative(root, target);
        var result = LevelOrder.Traversal(resRoot).SelectMany(l => l).ToArray();
        
        Assert.Equal(expected, result);
    }
}