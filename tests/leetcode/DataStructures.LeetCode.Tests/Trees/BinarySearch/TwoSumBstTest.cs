using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.BinarySearch;
using Xunit;
using Tree = DataStructures.LeetCode.Trees.BinarySearch.Tree;

namespace DataStructures.LeetCode.Tests.Trees.BinarySearch;

public class TwoSumBstTest
{
    [Theory]
    [InlineData(new[] { 5, 3, 6, 2, 4, 7 }, 9, true)]
    [InlineData(new[] { 5, 3, 6, 2, 4, 7 }, 28, false)]
    public void TwoSum_Test(int[] tree, int sum, bool expected)
    {
        var root = tree.Aggregate<int, TreeNode?>(null, Tree.Insert);

        var result = TwoSumBst.TwoSum(root, sum);
        
        Assert.Equal(expected, result);
    }
}