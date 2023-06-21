using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.BinarySearch;
using Xunit;
using Tree = DataStructures.LeetCode.Trees.BinarySearch.Tree;

namespace DataStructures.LeetCode.Tests.Trees.BinarySearch;

public class LowestCommonAncestorTest
{
    [Theory]
    [InlineData(new[] { 6, 2, 8, 0, 4, 7, 9, 3, 5 }, 3, 8, 6)]
    [InlineData(new[] { 6, 2, 8, 0, 4, 7, 9, 3, 5 }, 2, 4, 2)]
    public void Get_Test(int[] tree, int pVal, int qVal, int expVal)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);
        var p = Tree.Find(root, pVal);
        var q = Tree.Find(root, qVal);
        var expected = Tree.Find(root, expVal);

        var result = LowestCommonAncestor.Get(root, p, q);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 6, 2, 8, 0, 4, 7, 9, 3, 5 }, 3, 8, 6)]
    [InlineData(new[] { 6, 2, 8, 0, 4, 7, 9, 3, 5 }, 2, 4, 2)]
    public void GetIterative_Test(int[] tree, int pVal, int qVal, int expVal)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);
        var p = Tree.Find(root, pVal);
        var q = Tree.Find(root, qVal);
        var expected = Tree.Find(root, expVal);

        var result = LowestCommonAncestor.GetIterative(root, p, q);
        
        Assert.Equal(expected, result);
    }
}