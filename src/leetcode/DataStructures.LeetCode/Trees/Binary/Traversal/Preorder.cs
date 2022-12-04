namespace DataStructures.LeetCode.Trees.Binary.Traversal;

public static class Preorder
{
    public static IList<int> Traversal(TreeNode? root)
    {
        if (root == null) 
            return new List<int>();

        var list = new List<int> { root.Val };
        list.AddRange(Traversal(root.Right));
        list.AddRange(Traversal(root.Left));

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