using DataStructures.LeetCode.LinkedList;
using Xunit;

namespace DataStructures.LeetCode.Tests.LinkedList;

public class MergeTwoSortedLinkedListsTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { }, new[] { 0 }, new[] { 0 })]
    public void MergeIterative_Test(int[] list1, int[] list2, int[] expected)
    {
        var head1 = LinkedListTestHelper.CreateHeadFromList(list1);
        var head2 = LinkedListTestHelper.CreateHeadFromList(list2);

        var resHead = MergeTwoSortedLinkedLists.MergeIterative(head1, head2);
        var result = LinkedListTestHelper.CreateListFromHead(resHead);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { }, new[] { 0 }, new[] { 0 })]
    public void MergeRecursive_Test(int[] list1, int[] list2, int[] expected)
    {
        var head1 = LinkedListTestHelper.CreateHeadFromList(list1);
        var head2 = LinkedListTestHelper.CreateHeadFromList(list2);

        var resHead = MergeTwoSortedLinkedLists.MergeRecursive(head1, head2);
        var result = LinkedListTestHelper.CreateListFromHead(resHead);
        
        Assert.Equal(expected, result);
    }
}