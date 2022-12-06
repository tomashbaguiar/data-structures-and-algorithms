namespace DevTraining.Codility.CountingElements;

public static class MaxCounters
{
    public static int[] Solution(int[] array, int n)
    {
        var counters = new int[n];
        var max = 0;
        foreach (var e in array)
        {
            if (e >= 1 && e <= n)
            {
                var c = ++counters[e - 1];
                max = c > max ? c : max;
                continue;
            }

            if (e != n + 1) continue;
            for (var j = 0; j < n; j++)
            {
                counters[j] = max;
            }
        }

        return counters;
    }
}