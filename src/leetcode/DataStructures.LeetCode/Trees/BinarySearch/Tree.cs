using DataStructures.LeetCode.Trees.Binary;

namespace DataStructures.LeetCode.Trees.BinarySearch;

public static class Tree
{
    public static TreeNode Insert(TreeNode? root, int val)
    {
        if (root == null) return new TreeNode(val);

        if (val < root.Val)
        {
            root.Left = Insert(root.Left, val);
            return root;
        }

        root.Right = Insert(root.Right, val);
        return root;
    }
}