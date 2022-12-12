namespace DataStructures.LeetCode.Array;

public static class RotateImage
{
    public static void Rotate(int[][] matrix)
    {
        var n = matrix.Length;
        if (n == 1) return;

        matrix.RotateMatrix();
        matrix.InvertMatrix();
    }

    private static void InvertMatrix(this int[][] matrix)
    {
        var n = matrix.Length;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n / 2; j++)
            {
                (matrix[i][j], matrix[i][n - j - 1]) = (matrix[i][n - j - 1], matrix[i][j]);
            }
        }
    }

    private static void RotateMatrix(this int[][] matrix)
    {
        var n = matrix.Length;
        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }
    }
}