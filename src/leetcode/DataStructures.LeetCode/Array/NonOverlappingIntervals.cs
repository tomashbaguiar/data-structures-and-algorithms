namespace DataStructures.LeetCode.Array;

public static class NonOverlappingIntervals
{
    public static int RemoveOverlapping(int[][] intervals)
    {
        var qtd = Merge(intervals).Length;
        return intervals.Length - qtd;
    }

    private static int[][] Merge(int[][] intervals)
    {
        if (intervals.Length <= 1)
            return intervals;

        System.Array.Sort(intervals, (i1, i2) => i1[0].CompareTo(i2[0]));

        var result = new List<int[]>();
        var newInterval = intervals[0];
        result.Add(newInterval);
        foreach (var interval in intervals)
        {
            if (interval[0] < newInterval[1])
            {
                result.Add(newInterval);
                continue;
            }  
            
            newInterval = interval;
        }

        return result.ToArray();
    }
}