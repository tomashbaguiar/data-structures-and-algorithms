namespace DevTraining.Codility.Arrays;

public static class OddOccurrencesInArray
{
    public static int Solution(int[] array)
    {
        var hash = new HashSet<int>();
        foreach (var i in array)
        {
            if (hash.Contains(i))
            {
                hash.Remove(i);
                continue;
            }

            hash.Add(i);
        }

        return hash.FirstOrDefault();
    }
}