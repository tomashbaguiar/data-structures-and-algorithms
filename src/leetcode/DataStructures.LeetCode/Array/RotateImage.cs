namespace DataStructures.LeetCode.Array;

public static class RotateImage
{
    public static void Rotate(int[][] matrix)
    {
        var n = matrix.Length;
        if (n == 1) return;

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }
        
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n / 2; j++)
            {
                (matrix[i][j], matrix[i][n - j - 1]) = (matrix[i][n - j - 1], matrix[i][j]);
            }
        }
    }
}