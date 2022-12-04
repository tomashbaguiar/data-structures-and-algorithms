namespace DataStructures.LeetCode.Trees.Binary;

public static class Inversion
{
    public static TreeNode? Invert(TreeNode? root)
    {
        if (root == null) return root;
        
        Invert(root.Left);
        Invert(root.Right);
        (root.Left, root.Right) = (root.Right, root.Left);
        return root;
    }
    
    public static TreeNode? InvertIterative(TreeNode? root)
    {
        if (root == null) return root;

        var toVisit = new Queue<TreeNode>();
        toVisit.Enqueue(root);
        while (toVisit.Count != 0)
        {
            var node = toVisit.Dequeue();
            if (node.Right != null) toVisit.Enqueue(node.Right);
            if (node.Left != null) toVisit.Enqueue(node.Left);
            (node.Left, node.Right) = (node.Right, node.Left);
        }
        
        return root;
    }
}