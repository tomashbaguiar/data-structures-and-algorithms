using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class IntersectionOfTwoArraysTest
{
    [Theory]
    [InlineData(new [] { 1, 2, 2, 1 }, new [] { 2, 2 }, new [] { 2, 2 })]
    [InlineData(new [] { 4, 9, 5 }, new [] { 9, 4, 9, 8, 4 }, new [] { 4, 9 })]
    [InlineData(new [] { 3, 1, 2 }, new [] { 1, 1 }, new [] { 1 })]
    public void IntersectHashTable_Test(int[] array1, int[] array2, int[] expected)
    {
        var result = IntersectionOfTwoArrays.IntersectHashTable(array1, array2);
        
        Assert.Equal(expected, result);
    }
}