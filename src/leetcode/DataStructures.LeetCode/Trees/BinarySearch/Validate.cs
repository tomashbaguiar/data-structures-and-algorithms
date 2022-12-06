using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.Binary.Traversal.DepthFirst;

namespace DataStructures.LeetCode.Trees.BinarySearch;

public static class Validate
{
    public static bool IsValid(TreeNode? root)
    {
        return IsValid(root, int.MinValue, int.MaxValue);
    }

    private static bool IsValid(TreeNode? root, int minValue, int maxValue)
    {
        if (root == null) return true;

        if (minValue < root.Val && maxValue > root.Val)
            return IsValid(root.Left, minValue, root.Val) && IsValid(root.Right, root.Val, maxValue);

        return false;
    }

    public static bool IsValidIterative(TreeNode? root)
    {
        if (root == null) return true;

        var tree = InOrder.TraversalIterative(root);
        for (var i = 0; i < tree.Count - 1; i++)
        {
            if (tree[i] >= tree[i + 1]) return false;
        }

        return true;
    }
}