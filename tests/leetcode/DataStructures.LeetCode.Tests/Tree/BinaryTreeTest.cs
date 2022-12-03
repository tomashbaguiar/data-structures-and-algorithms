using System.Linq;
using DataStructures.LeetCode.Tree;
using Xunit;

namespace DataStructures.LeetCode.Tests.Tree;

public class BinaryTreeTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    public void PreorderTraversal_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, BinaryTree.Add);

        var result = BinaryTree.PreorderTraversal(root);
        
        Assert.Equal(expected.ToList(), result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    public void PreorderTraversalIterative_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, BinaryTree.Add);

        var result = BinaryTree.PreorderTraversalIterative(root);
        
        Assert.Equal(expected.ToList(), result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [InlineData(new[] { 3, 1, 2 }, new[] { 2, 1, 3 })]
    public void PostorderTraversal_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, BinaryTree.Add);

        var result = BinaryTree.PostorderTraversal(root);
        
        Assert.Equal(expected.ToList(), result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [InlineData(new[] { 3, 1, 2 }, new[] { 2, 1, 3 })]
    public void PostorderTraversalIterative_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, BinaryTree.Add);

        var result = BinaryTree.PostorderTraversalIterative(root);
        
        Assert.Equal(expected.ToList(), result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 3, 1, 2 }, new[] { 1, 2, 3 })]
    public void InorderTraversal_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, BinaryTree.Add);

        var result = BinaryTree.InorderTraversal(root);
        
        Assert.Equal(expected.ToList(), result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 3, 1, 2 }, new[] { 1, 2, 3 })]
    public void InorderTraversalIterative_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, BinaryTree.Add);

        var result = BinaryTree.InorderTraversalIterative(root);
        
        Assert.Equal(expected.ToList(), result);
    }
}