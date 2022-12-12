namespace DevTraining.Codility.TimeComplexity;

public static class PermutationMissingElement
{
    public static int Solution(int[] array)
    {
        var ordArray = array.OrderBy(c => c).ToArray();
        var count = 1;
        foreach (var e in ordArray)
        {
            if (e != count) return count;
            count++;
        }

        return count;
    }
}