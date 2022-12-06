namespace DataStructures.LeetCode.Trees.Binary;

public static class Tree
{
    public static TreeNode Insert(TreeNode? root, int val)
    {
        if (root == null) return new TreeNode(val);
        
        var toVisit = new Queue<TreeNode>();
        toVisit.Enqueue(root);
        while (toVisit.Count != 0) 
        {
            var temp = toVisit.Peek();
            toVisit.Dequeue();
 
            if (temp.Left == null) 
            {
                temp.Left = new TreeNode(val);
                break;
            }

            toVisit.Enqueue(temp.Left);

            if (temp.Right == null) 
            {
                temp.Right = new TreeNode(val);
                break;
            }

            toVisit.Enqueue(temp.Right);
        }

        return root;
    }
}