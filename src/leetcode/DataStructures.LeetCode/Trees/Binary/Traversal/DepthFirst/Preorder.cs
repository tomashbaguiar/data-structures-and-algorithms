namespace DataStructures.LeetCode.Trees.Binary.Traversal.DepthFirst;

public static class Preorder
{
    public static IList<int> Traversal(TreeNode? root)
    {
        var list = new List<int>();
        if (root == null)
            return list;

        list.Add(root.Val);
        list.AddRange(Traversal(root.Left));
        list.AddRange(Traversal(root.Right));

        return list;
    }

    public static IList<int> TraversalIterative(TreeNode? root)
    {
        var list = new List<int>();
        if (root == null) return list;
        
        var toVisit = new Stack<TreeNode>();
        toVisit.Push(root);
        while (toVisit.Count != 0) 
        {
            var node = toVisit.Pop();
            list.Add(node.Val);
            if (node.Right != null) toVisit.Push(node.Right);
            if (node.Left != null) toVisit.Push(node.Left);
        }
        
        return list;
    }
}