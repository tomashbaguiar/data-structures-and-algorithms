namespace DataStructures.LeetCode.Tree;

public static class BinaryTree
{
    public static TreeNode Add(TreeNode? root, int val)
    {
        if (root == null) return new TreeNode(val);

        if (val < root.val)
        {
            root.left = Add(root.left, val);
            return root;
        }

        root.right = Add(root.right, val);
        return root;
    }
}