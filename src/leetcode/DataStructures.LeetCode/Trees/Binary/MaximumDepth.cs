using DataStructures.LeetCode.Trees.Binary.Traversal;
using DataStructures.LeetCode.Trees.Binary.Traversal.BreadthFirst;

namespace DataStructures.LeetCode.Trees.Binary;

public static class MaximumDepth
{
    public static int DepthFirstGet(TreeNode? root)
    {
        return LevelOrder.Traversal(root).Count;
    }

    public static int BreadthFirstGet(TreeNode? root)
    {
        if (root == null) return 0;
        
        var maxLeft = BreadthFirstGet(root.Left);
        var maxRight = BreadthFirstGet(root.Right);
        
        return Math.Max(maxLeft, maxRight) + 1;
    }
}