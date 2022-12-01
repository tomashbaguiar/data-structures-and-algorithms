namespace DevTraining.Codility.TimeComplexity;

public static class TapeEquilibrium
{
    public static int Solution(int[] array)
    {
        var len = array.Length - 1;
        var sums = new int[len];
        sums[0] = array[0];
        var inv = new int[len];
        inv[0] = array[len];
        for (var i = 1; i < len; i++)
        {
            sums[i] = sums[i - 1] + array[i];
            inv[i] = inv[i - 1] + array[len - i];
        }

        var min = int.MaxValue;
        for (var i = 0; i < len; i++)
        {
            var diff = Math.Abs(sums[i] - inv[len - i - 1]);
            min = diff < min ? diff : min;
        }

        return min;
    }
}