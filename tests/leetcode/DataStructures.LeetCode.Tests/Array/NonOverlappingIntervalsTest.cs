using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class NonOverlappingIntervalsTest
{
    [Fact]
    public void RemoveOverlapping_Test()
    {
        var intervals = new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 1, 3 } };
        const int expected = 1;

        var result = NonOverlappingIntervals.RemoveOverlapping(intervals);
        
        Assert.Equal(expected, result);
    }
}