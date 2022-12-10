namespace DataStructures.LeetCode.Array;

public static class Search2dMatrix
{
    public static bool BinarySearch(int[][] matrix, int target)
    {
        var m = matrix.Length;
        if (m == 0) return false;
        
        var row = 0;
        var col = matrix[0].Length - 1;
        while (col >= 0 && row <= m - 1)
        {
            if (target == matrix[row][col]) return true;

            if (target < matrix[row][col])
            {
                col--;
                continue;
            }

            if (target > matrix[row][col])
            {
                row++;
            }
        }
        
        return false;
    }
}