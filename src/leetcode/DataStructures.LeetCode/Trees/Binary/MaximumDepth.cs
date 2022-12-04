using DataStructures.LeetCode.Trees.Binary.Traversal;

namespace DataStructures.LeetCode.Trees.Binary;

public static class MaximumDepth
{
    public static int Get(TreeNode? root)
    {
        return LevelOrder.Traversal(root).Count;
    }
}