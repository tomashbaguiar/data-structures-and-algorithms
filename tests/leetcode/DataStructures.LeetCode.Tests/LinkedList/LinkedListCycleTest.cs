using DataStructures.LeetCode.LinkedList;
using Xunit;

namespace DataStructures.LeetCode.Tests.LinkedList;

public class LinkedListCycleTest
{
    [Theory]
    [InlineData(new[] { 3, 2, 0, -4 }, 1, true)]
    [InlineData(new[] { 1, 2 }, 0, true)]
    [InlineData(new[] { 1 }, -1, false)]
    [InlineData(new int[] {}, -1, false)]
    public void HasCycle_Test(int[] list, int pos, bool expected)
    {
        var head = LinkedListTestHelper.CreateHead(list);
        head?.CreateCycle(pos);

        var result = LinkedListCycle.HasCycle(head);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 3, 2, 0, -4 }, 1, true)]
    [InlineData(new[] { 1, 2 }, 0, true)]
    [InlineData(new[] { 1 }, -1, false)]
    [InlineData(new int[] {}, -1, false)]
    public void HasCycleFastSlow_Test(int[] list, int pos, bool expected)
    {
        var head = LinkedListTestHelper.CreateHead(list);
        head?.CreateCycle(pos);

        var result = LinkedListCycle.HasCycleFastSlow(head);
        
        Assert.Equal(expected, result);
    }
}