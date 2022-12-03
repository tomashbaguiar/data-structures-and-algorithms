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

    public static IList<int> PreorderTraversal(TreeNode? root)
    {
        if (root == null) 
            return new List<int>();

        var list = new List<int> { root.val };
        list.AddRange(PreorderTraversal(root.right));
        list.AddRange(PreorderTraversal(root.left));

        return list;
    }
    
    public static IList<int> PreorderTraversalIterative(TreeNode? root)
    {
        var list = new List<int>();
        if (root == null) return list;
        
        var toVisit = new Stack<TreeNode>();
        toVisit.Push(root);
        while (toVisit.Count != 0) 
        {
            var node = toVisit.Pop();
            list.Add(node.val);
            if (node.right != null) toVisit.Push(node.right);
            if (node.left != null) toVisit.Push(node.left);
        }
        
        return list;
    }

    public static IList<int> PostorderTraversal(TreeNode? root)
    {
        if (root == null) 
            return new List<int>();

        var list = new List<int>();
        list.AddRange(PostorderTraversal(root.left));
        list.AddRange(PostorderTraversal(root.right));
        list.Add(root.val);
        
        return list;
    }

    public static IList<int> PostorderTraversalIterative(TreeNode? root)
    {
        var list = new Stack<int>();
        if (root == null) return list.ToList();
        
        var toVisit = new Stack<TreeNode>();
        toVisit.Push(root);
        while (toVisit.Count != 0)
        {
            var node = toVisit.Pop();
            list.Push(node.val);
            if (node.left != null) toVisit.Push(node.left);
            if (node.right != null) toVisit.Push(node.right);
        }

        return list.ToList();
    }

    public static IList<int> InorderTraversal(TreeNode? root)
    {
        if (root == null) 
            return new List<int>();

        var list = new List<int>();
        list.AddRange(InorderTraversal(root.left));
        list.Add(root.val);
        list.AddRange(InorderTraversal(root.right));

        return list;
    }

    public static IList<int> InorderTraversalIterative(TreeNode? root)
    {
        var list = new List<int>();

        var stack = new Stack<TreeNode>();
        var curr = root;

        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            
            curr = stack.Pop();
            list.Add(curr.val);
            curr = curr.right;
        }

        return list;
    }
}