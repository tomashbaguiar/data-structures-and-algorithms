namespace DevTraining.Codility.CountingElements;

public static class PermutationCheck
{
    public static int Solution(int[] array)
    {
        var hash = new HashSet<int>();
        foreach (var e in array)
        {
            if (hash.Contains(e)) return 0;
            hash.Add(e);
        }

        return hash.Max() == array.Length ? 1 : 0;
    }
}