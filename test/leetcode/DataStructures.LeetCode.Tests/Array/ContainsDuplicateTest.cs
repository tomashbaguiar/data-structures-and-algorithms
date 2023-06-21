using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class ContainsDuplicateTest
{
    [Theory]
    [InlineData(new [] { 1, 2, 3 }, false)]
    [InlineData(new [] { 1, 2, 2 }, true)]
    public void Verify_Test(int[] array, bool expected)
    {
        var result = ContainsDuplicate.VerifyHashTable(array);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new [] { 1, 2, 3 }, false)]
    [InlineData(new [] { 1, 2, 2 }, true)]
    public void VerifyWithLinq_Test(int[] array, bool expected)
    {
        var result = ContainsDuplicate.VerifyLinq(array);
        
        Assert.Equal(expected, result);
    }
}