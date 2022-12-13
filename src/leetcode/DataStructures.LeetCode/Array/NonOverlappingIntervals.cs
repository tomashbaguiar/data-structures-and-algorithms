namespace DataStructures.LeetCode.Array;

public static class NonOverlappingIntervals
{
    public static int RemoveOverlapping(int[][] intervals)
    {
        if (intervals.Length <= 1)
            return 0;

        System.Array.Sort(intervals, (i1, i2) => i1[1].CompareTo(i2[1]));
        var count = 0;
        var lastEnd = intervals[0][1];
        for (var i = 1; i < intervals.Length; i++)
        {
            var begin = intervals[i][0];
            var end = intervals[i][1];
            if (begin < lastEnd)
            {
                count++;
                continue;
            }

            lastEnd = end;
        }

        return count;
    }
}