using DataStructures.LeetCode.StackQueue;
using Xunit;

namespace DataStructures.LeetCode.Tests.StackQueue;

public class QueueImplementedWithStacksTest
{
    [Fact]
    public void FirstTest()
    {
        var queue = new MyQueue();
        queue.Push(1);
        queue.Push(2);

        var first = queue.Peek();
        var second = queue.Pop();
        var third = queue.Empty();
        
        Assert.Equal(1, first);
        Assert.Equal(1, second);
        Assert.False(third);
    }
}