namespace DevTraining.Codility;

public static class BinaryGap
{
    public static int Solution(int n)
    {
        var nBinString = Convert.ToString(n, 2);

        // Dynamic sliding window algorithm
        var start = 0;
        var maxCount = 0;
        for (var i = 0; i < nBinString.Length; i++)
        {
            var c = nBinString[i];

            if (c != '1') continue;
            
            var count = i - start - 1;
            maxCount = count > maxCount ? count : maxCount;
            start = i;
        }

        return maxCount;
    }
}