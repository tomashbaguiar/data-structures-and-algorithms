namespace DataStructures.LeetCode.Trees.Binary;

public static class PathSum
{
    public static bool HasPathSum(TreeNode? root, int target)
    {
        if(root == null) return false;
    
        if(root.Left == null && root.Right == null && root.Val == target) return true;

        var left = HasPathSum(root.Left, target - root.Val);
        var right = HasPathSum(root.Right, target - root.Val);
        return left || right;
    }

    public static bool HasPathSumIterative(TreeNode? root, int target)
    {
        if (root == null) return false;

        var toVisit = new Stack<TreeNode>();
        var pathSum = new Stack<int>();
        toVisit.Push(root);
        pathSum.Push(root.Val);
        while (toVisit.Count != 0)
        {
            var node = toVisit.Pop();
            var sum = pathSum.Pop();
            if (node.Left == null && node.Right == null)
            {
                if (sum == target) return true;
                continue;
            }

            if (node.Left != null)
            {
                toVisit.Push(node.Left);
                pathSum.Push(sum + node.Left.Val);
            }

            if (node.Right == null) continue;
            toVisit.Push(node.Right);
            pathSum.Push(sum + node.Right.Val);
        }

        return false;
    }
}