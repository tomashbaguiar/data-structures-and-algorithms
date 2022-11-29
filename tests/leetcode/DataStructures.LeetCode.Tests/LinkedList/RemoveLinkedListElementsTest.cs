using DataStructures.LeetCode.LinkedList;
using Xunit;

namespace DataStructures.LeetCode.Tests.LinkedList;

public class RemoveLinkedListElementsTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { }, 1, new int[] { })]
    [InlineData(new[] { 7, 7, 7, 7 }, 7, new int[] { })]
    [InlineData(new[] { 1, 2, 2, 1 }, 2, new[] { 1, 1 })]
    public void RemoveIterative_Test(int[] list, int val, int[] expected)
    {
        var head = LinkedListTestHelper.CreateHeadFromList(list);

        var resHead = RemoveLinkedListElements.RemoveIterative(head, val);
        var result = LinkedListTestHelper.CreateListFromHead(resHead);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { }, 1, new int[] { })]
    [InlineData(new[] { 7, 7, 7, 7 }, 7, new int[] { })]
    [InlineData(new[] { 1, 2, 2, 1 }, 2, new[] { 1, 1 })]
    public void RemoveRecursive_Test(int[] list, int val, int[] expected)
    {
        var head = LinkedListTestHelper.CreateHeadFromList(list);

        var resHead = RemoveLinkedListElements.RemoveRecursive(head, val);
        var result = LinkedListTestHelper.CreateListFromHead(resHead);
        
        Assert.Equal(expected, result);
    }
}