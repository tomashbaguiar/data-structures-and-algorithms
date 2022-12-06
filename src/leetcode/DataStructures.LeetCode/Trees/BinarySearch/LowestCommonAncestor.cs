using DataStructures.LeetCode.Trees.Binary;

namespace DataStructures.LeetCode.Trees.BinarySearch;

public static class LowestCommonAncestor
{
    public static TreeNode? Get(TreeNode? root, TreeNode? p, TreeNode? q)
    {
        if (root == null) return null;
        
        if (root.Val > p?.Val && root.Val > q?.Val) 
        {
            return Get(root.Left, p, q);
        }
        
        if (root.Val < p?.Val && root.Val < q?.Val) 
        {
            return Get(root.Right, p, q);
        }
        
        return root;
    }

    public static TreeNode? GetIterative(TreeNode? root, TreeNode? p, TreeNode? q)
    {
        while (true)
        {
            if (root == null) return null;

            if (root.Val > p?.Val && root.Val > q?.Val)
            {
                root = root.Left;
                continue;
            }

            if (!(root.Val < p?.Val) || !(root.Val < q?.Val)) return root;
            root = root.Right;
        }
    }
}