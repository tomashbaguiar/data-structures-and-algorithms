namespace DataStructures.LeetCode.Trees.Binary;

public static class Symmetry
{
    public static bool IsSymmetric(TreeNode? root) 
    {
        return root == null || VerifySymmetry(root.Left, root.Right);
    }

    private static bool VerifySymmetry(TreeNode? left, TreeNode? right)
    {
        if(left == null || right == null) return left == right;
        if(left.Val != right.Val) return false;
        
        var l = VerifySymmetry(left.Left, right.Right); 
        var r = VerifySymmetry(left.Right, right.Left);
        return l && r;
    }
}