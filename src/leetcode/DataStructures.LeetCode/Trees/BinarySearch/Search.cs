using DataStructures.LeetCode.Trees.Binary;

namespace DataStructures.LeetCode.Trees.BinarySearch;

public static class Search
{
    public static TreeNode? SearchBreadthFirst(TreeNode? root, int target)
    {
        if (root == null) return null;
        if (root.Val == target) return root;

        var l = SearchBreadthFirst(root.Left, target);
        if (l?.Val == target) return l;
        var r = SearchBreadthFirst(root.Right, target);
        return r?.Val == target ? r : null;
    }
    
    public static TreeNode? SearchBreadthFirstIterative(TreeNode? root, int target)
    {
        if (root == null) return null;

        var toVisit = new Queue<TreeNode>();
        toVisit.Enqueue(root);
        var node = root;
        while (toVisit.Count != 0 && node.Val != target)
        {
            node = toVisit.Dequeue();
            if (node.Left != null) toVisit.Enqueue(node.Left);
            if (node.Right != null) toVisit.Enqueue(node.Right);
        }

        return node.Val == target ? node : null;
    }
}