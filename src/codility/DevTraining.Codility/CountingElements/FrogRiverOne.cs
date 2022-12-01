namespace DevTraining.Codility.CountingElements;

public static class FrogRiverOne
{
    public static int Solution(int x, int[] array)
    {
        var path = new HashSet<int>();
        for (var i = 0; i < array.Length; i++)
        {
            var leaf = array[i];
            if (!path.Contains(leaf)) path.Add(leaf);
            if (path.Count == x) return i;
        }

        return -1;
    }
}