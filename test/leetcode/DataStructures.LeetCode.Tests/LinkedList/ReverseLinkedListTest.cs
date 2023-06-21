using DataStructures.LeetCode.LinkedList;
using Xunit;

namespace DataStructures.LeetCode.Tests.LinkedList;

public class ReverseLinkedListTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
    [InlineData(new[] { 1, 2 }, new[] { 2, 1 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    public void ReverseIterative_Test(int[] list, int[] expected)
    {
        var head = LinkedListTestHelper.CreateHeadFromList(list);

        var resHead = ReverseLinkedList.ReverseIterative(head);
        var result = LinkedListTestHelper.CreateListFromHead(resHead);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
    [InlineData(new[] { 1, 2 }, new[] { 2, 1 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    public void ReverseRecursive_Test(int[] list, int[] expected)
    {
        var head = LinkedListTestHelper.CreateHeadFromList(list);

        var resHead = ReverseLinkedList.ReverseRecursive(head);
        var result = LinkedListTestHelper.CreateListFromHead(resHead);
        
        Assert.Equal(expected, result);
    }
}