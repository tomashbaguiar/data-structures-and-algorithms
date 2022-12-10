namespace DataStructures.LeetCode.Array;

public static class PascalsTriangleIi
{
    public static IList<int> GetRow(int rowIndex)
    {
        var triangle = PascalsTriangle.Generate(rowIndex + 1);
        return triangle[rowIndex];
    }
}