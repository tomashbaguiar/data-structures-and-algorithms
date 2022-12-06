using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.BinarySearch;
using Xunit;
using Tree = DataStructures.LeetCode.Trees.Binary.Tree;

namespace DataStructures.LeetCode.Tests.Trees.BinarySearch;

public class ValidateTest
{
    [Theory]
    [InlineData(new[] { 5, 1, 4, 3, 6 }, false)]
    [InlineData(new[] { 2, 1, 3 }, true)]
    [InlineData(new[] { 5, 4, 6, 3, 7 }, false)]
    public void IsValid_Test(int[] tree, bool expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var result = Validate.IsValid(root);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 5, 1, 4, 3, 6 }, false)]
    [InlineData(new[] { 2, 1, 3 }, true)]
    [InlineData(new[] { 5, 4, 6, 3, 7 }, false)]
    public void IsValidIterative_Test(int[] tree, bool expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var result = Validate.IsValidIterative(root);
        
        Assert.Equal(expected, result);
    }
}