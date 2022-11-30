using DataStructures.LeetCode.LinkedList;
using Xunit;

namespace DataStructures.LeetCode.Tests.LinkedList;

public class RemoveDuplicateFromSortedListTest
{
    [Theory]
    [InlineData(new[] { 1, 1, 2 }, new[] { 1, 2 })]
    [InlineData(new[] { 1, 1, 2, 3, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 1, 1 }, new[] { 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void DeleteIterative_Test(int[] list, int[] expected)
    {
        var head = LinkedListTestHelper.CreateHeadFromList(list);

        var resHead = RemoveDuplicateFromSortedList.DeleteIterative(head);
        var result = LinkedListTestHelper.CreateListFromHead(resHead);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 1, 2 }, new[] { 1, 2 })]
    [InlineData(new[] { 1, 1, 2, 3, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 1, 1 }, new[] { 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void DeleteRecursive_Test(int[] list, int[] expected)
    {
        var head = LinkedListTestHelper.CreateHeadFromList(list);

        var resHead = RemoveDuplicateFromSortedList.DeleteRecursive(head);
        var result = LinkedListTestHelper.CreateListFromHead(resHead);
        
        Assert.Equal(expected, result);
    }
}