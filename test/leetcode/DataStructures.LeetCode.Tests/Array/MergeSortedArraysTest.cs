using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class MergeSortedArraysTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [InlineData(new[] { 0 }, 0, new [] { 1 }, 1, new[] { 1 })]
    [InlineData(new [] { -1, 0, 0, 3, 3, 3, 0, 0, 0 }, 6, new [] { 1, 2, 2 }, 3, new [] { -1, 0, 0, 1, 2, 2, 3, 3, 3 })]
    [InlineData(new [] { -1, -1, 0, 0, 0, 0 }, 4, new [] { -1, 0 }, 2, new [] { -1, -1, -1, 0, 0, 0 })]
    public void MergeBruteForce_Test(int[] array1, int m, int[] array2, int n, int[] expected)
    {
        MergeSortedArrays.MergeBruteForce(array1, m, array2, n);

        Assert.Equal(expected, array1);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [InlineData(new[] { 0 }, 0, new [] { 1 }, 1, new[] { 1 })]
    [InlineData(new [] { -1, 0, 0, 3, 3, 3, 0, 0, 0 }, 6, new [] { 1, 2, 2 }, 3, new [] { -1, 0, 0, 1, 2, 2, 3, 3, 3 })]
    [InlineData(new [] { -1, -1, 0, 0, 0, 0 }, 4, new [] { -1, 0 }, 2, new [] { -1, -1, -1, 0, 0, 0 })]
    public void Merge_Test(int[] array1, int m, int[] array2, int n, int[] expected)
    {
        MergeSortedArrays.Merge(array1, m, array2, n);

        Assert.Equal(expected, array1);
    }
}