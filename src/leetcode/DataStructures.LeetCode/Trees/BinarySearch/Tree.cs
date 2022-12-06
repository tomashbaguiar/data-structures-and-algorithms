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

    public static TreeNode InsertIterative(TreeNode? root, int val)
    {
        var node = new TreeNode(val);
        if (root == null) return node;

        var curr = root;
        while (curr != null)
        {
            if (curr.Val > val)
            {
                if (curr.Left != null) curr = curr.Left;
                else
                {
                    curr.Left = node;
                    return root;
                }
            }
            else if (curr.Right != null) curr = curr.Right;
            else
            {
                curr.Right = node;
                return root;
            }
        }

        return root;
    }
}