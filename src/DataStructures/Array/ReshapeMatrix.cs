namespace DataStructures.Array;

public static class ReshapeMatrix
{
    public static int[][] Reshape(int[][] matrix, int r, int c)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        if (r * c != m * n) return matrix;

        var result = new int[r][];
        for (var i = 0; i < m * n; i++)
        {
            if (i / r == 0) result[i] = new int[c];
            result[i / c][i % c] = matrix[i / n][i % n];
        }

        return result;
    }
}