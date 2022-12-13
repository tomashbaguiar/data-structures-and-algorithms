using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class NonOverlappingIntervalsTest
{
    [Theory]
    [InlineData(1, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 1, 3 })]
    [InlineData(2, new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 })]
    [InlineData(0, new[] { 1, 2 }, new[] { 2, 3 })]
    [InlineData(2, new[] { -10, -5 }, new[] { -6, -3 }, new[] { 0, 1 }, new[] { 0, 3 }, new[] { 1, 2 })]
    [InlineData(2, new[] { 1, 100 }, new[] { 11, 22 }, new[] { 1, 11 }, new[] { 2, 12 })]
    public void RemoveOverlapping_Test(int expected, params int[][] intervals)
    {
        var result = NonOverlappingIntervals.RemoveOverlapping(intervals);
        
        Assert.Equal(expected, result);
    }
}