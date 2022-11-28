namespace DataStructures.LeetCode.Array;

public static class PascalsTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var partial = new int[numRows][];
        for (var i = 0; i < numRows; i++)
        {
            partial[i] = new int[i + 1];
            for (var j = 0; j < i + 1; j++)
            {
                partial[i][j] = j == 0 || j == i 
                    ? 1 
                    : partial[i - 1][j - 1] + partial[i - 1][j];
            }
        }

        return partial;
    }
}