namespace DataStructures.LeetCode.Array;

public static class SubarraySumEqualsK
{
    public static int FindBruteForce(int[] array, int k)
    {
        var n = array.Length;
        if (n == 0) return 0;
        if (n == 1 && array[0] == k) return 1;

        var allSum = array.Sum();
        if (allSum < k) return 0;
        if (allSum == k) return 1;

        var count = 0;
        for (var i = 0; i < n; i++)
        {
            var sum = array[i];
            var j = i + 1;
            while (j < n && sum != k)
            {
                sum += array[j++];
            }

            if (sum == k) count++;
        }

        return count;
    }
}