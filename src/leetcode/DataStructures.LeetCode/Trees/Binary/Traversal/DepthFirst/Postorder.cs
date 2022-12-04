namespace DataStructures.LeetCode.Trees.Binary.Traversal.DepthFirst;

public static class Postorder
{
    public static IList<int> Traversal(TreeNode? root)
    {
        if (root == null) 
            return new List<int>();

        var list = new List<int>();
        list.AddRange(Traversal(root.Left));
        list.AddRange(Traversal(root.Right));
        list.Add(root.Val);
        
        return list;
    }

    public static IList<int> TraversalIterative(TreeNode? root)
    {
        var list = new Stack<int>();
        if (root == null) return list.ToList();
        
        var toVisit = new Stack<TreeNode>();
        toVisit.Push(root);
        while (toVisit.Count != 0)
        {
            var node = toVisit.Pop();
            list.Push(node.Val);
            if (node.Left != null) toVisit.Push(node.Left);
            if (node.Right != null) toVisit.Push(node.Right);
        }

        return list.ToList();
    }
}