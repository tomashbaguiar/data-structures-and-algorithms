namespace DataStructures.LeetCode.Array;

public static class SpiralMatrix
{
    public static int[][] Generate(int n)
    {
        var lookup = Enumerable.Range(1, n * n).ToArray();
        var matrix = new int[n][];
        for (var k = 0; k < n; k++) matrix[k] = new int[n];

        var j = 0;
        for (var t = 0; t <= n / 2; t++)
        {
            for (var i = t; i < n - t; i++) matrix[t][i] = lookup[j++];
            for (var i = t + 1; i < n - t; i++) matrix[i][n - 1 - t] = lookup[j++];
            for (var i = n - 2 - t; i >= t; i--) matrix[n - 1 - t][i] = lookup[j++];
            for (var i = n - 2 - t; i > t; i--) matrix[i][t] = lookup[j++];
        }

        return matrix;
    }
}