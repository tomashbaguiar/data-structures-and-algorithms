﻿using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.Binary.Traversal;
using DataStructures.LeetCode.Trees.Binary.Traversal.DepthFirst;
using Xunit;

namespace DataStructures.LeetCode.Tests.Trees.Binary.Traversal.DepthFirst;

public class InOrderTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 2, 1, 3 })]
    [InlineData(new[] { 3, 1, 2 }, new[] { 1, 3, 2 })]
    public void Traversal_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var result = InOrder.Traversal(root);
        
        Assert.Equal(expected.ToList(), result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 2, 1, 3 })]
    [InlineData(new[] { 3, 1, 2 }, new[] { 1, 3, 2 })]
    public void TraversalIterative_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var result = InOrder.TraversalIterative(root);
        
        Assert.Equal(expected.ToList(), result);
    }
}