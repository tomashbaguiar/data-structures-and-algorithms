namespace DataStructures.LeetCode.Trees.Binary;

public static class Tree
{
    public static TreeNode Add(TreeNode? root, int val)
    {
        if (root == null) return new TreeNode(val);

        if (val < root.Val)
        {
            root.Left = Add(root.Left, val);
            return root;
        }

        root.Right = Add(root.Right, val);
        return root;
    }
}