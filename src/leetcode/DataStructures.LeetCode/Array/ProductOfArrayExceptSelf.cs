namespace DataStructures.LeetCode.Array;

public static class ProductOfArrayExceptSelf
{
    public static IEnumerable<int> Calculate(int[] nums)
    {
        var n = nums.Length;
        var l = new int[n];
        var r = new int[n];
        var ans = new int[n];
        for (var i = 0; i < n; i++) 
        {
            l[i] = 1;
            r[i] = 1;
            ans[i] = 1;
        }

        for (var i = 1; i < n; i++)
        {
            l[i] = l[i - 1] * nums[i - 1];
        }

        for (var i = n - 2; i >= 0; i--)
        {
            r[i] = r[i + 1] * nums[i + 1];
        }

        for (var i = 0; i < n; i++)
        {
            ans[i] = l[i] * r[i];
        }

        return ans;
    }

    public static int[] Calculate_LessSpace(int[] nums)
    {
        var n = nums.Length;
        var ans = new int[n];
        for (var i = 0; i < n; i++) ans[i] = 1;
        
        for (var i = 1; i < n; i++)
        {
            ans[i] = ans[i - 1] * nums[i - 1];
        }

        var productR = nums[n - 1];
        for (var i = n - 2; i >= 0; i--)
        {
            ans[i] *= productR;
            productR *= nums[i];
        }

        return ans;
    }
}