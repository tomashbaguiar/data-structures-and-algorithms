namespace DataStructures.LeetCode.Array;

public static class SearchMatrix
{
    public static bool SearchBruteForce(int[][] matrix, int target)
    {
        foreach (var t in matrix)
        {
            foreach (var t1 in t)
            {
                if (t1 == target)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool BinarySearch(int[][] matrix, int target)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var high = rows * cols - 1;
        var low = 0;

        while (low != high)
        {
            var mid = (high + low - 1) >> 1;
            var curr = matrix[mid / cols][mid % cols];
            if (curr < target) low = mid + 1;
            else high = mid;
        }

        return matrix[high / cols][high % cols] == target;
    }
}