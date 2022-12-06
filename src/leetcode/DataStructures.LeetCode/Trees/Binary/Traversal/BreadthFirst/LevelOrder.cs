namespace DataStructures.LeetCode.Trees.Binary.Traversal.BreadthFirst;

public static class LevelOrder
{
    public static IList<IList<int>> TraversalIterative(TreeNode? root)
    {
        var output = new List<IList<int>>();
        if (root == null)
            return output;

        var toVisit = new Queue<TreeNode>();
        toVisit.Enqueue(root);
        while (toVisit.Count != 0)
        {
            var level = toVisit.Count;
            var children = new List<int>();
            for (var i = 0; i < level; i++)
            {
                var node = toVisit.Dequeue();
                children.Add(node.Val);
                if (node.Left != null) toVisit.Enqueue(node.Left);
                if (node.Right != null) toVisit.Enqueue(node.Right);
            }
            output.Add(children);
        }

        return output;
    }

    public static IList<IList<int>> Traversal(TreeNode? root)
    {
        var output = new List<IList<int>>();
        output.BuildLevel(root, 0);
        return output;
    }

    private static void BuildLevel(this List<IList<int>> output, TreeNode? root, int level)
    {
        if (root == null) return;
        if (output.Count == level) output.Add(new List<int>());
        
        output[level].Add(root.Val);
        output.BuildLevel(root.Left, level + 1);
        output.BuildLevel(root.Right, level + 1);
    }
}