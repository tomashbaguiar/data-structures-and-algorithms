namespace DataStructures.LeetCode.Trees.Binary.Traversal.DepthFirst;

public static class InOrder
{
    public static IList<int> Traversal(TreeNode? root)
    {
        var list = new List<int>();
        if (root == null) return list;
        
        list.AddRange(Traversal(root.Left));
        list.Add(root.Val);
        list.AddRange(Traversal(root.Right));

        return list;
    }

    public static IList<int> TraversalIterative(TreeNode? root)
    {
        var list = new List<int>();

        var stack = new Stack<TreeNode>();
        var curr = root;

        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.Left;
            }
            
            curr = stack.Pop();
            list.Add(curr.Val);
            curr = curr.Right;
        }

        return list;
    }
}