using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.Binary.Traversal.DepthFirst;

namespace DataStructures.LeetCode.Trees.BinarySearch;

public static class TwoSumBst
{
    public static bool TwoSum(TreeNode? root, int sum)
    {
        var tree = InOrder.Traversal(root).ToArray();
        return Array.TwoSum.TwoSumHashTable(tree, sum).Any();
    }
}