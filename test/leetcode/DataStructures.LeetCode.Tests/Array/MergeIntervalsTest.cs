using System.Collections.Generic;
using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class MergeIntervalsTest
{
    [Fact]
    public void Merge_Test()
    {
        var intervals = new List<int[]> { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } }
            .ToArray();
        var expected = new List<int[]> { new[] { 1, 6 }, new[] { 8, 10 }, new[] { 15, 18 } }.ToArray();

        var result = MergeIntervals.Merge(intervals);
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Merge_Test_AlmostOverlap()
    {
        var intervals = new List<int[]> { new[] { 1, 4 }, new[] { 5, 6 } }
            .ToArray();

        var result = MergeIntervals.Merge(intervals);
        
        Assert.Equal(intervals, result);
    }
    
    [Fact]
    public void Merge_Test_Overlap()
    {
        var intervals = new List<int[]> { new[] { 1, 4 }, new[] { 0, 4 } }
            .ToArray();
        var expected = new List<int[]> { new[] { 0, 4 } }
            .ToArray();

        var result = MergeIntervals.Merge(intervals);
        
        Assert.Equal(expected, result);
    }
}