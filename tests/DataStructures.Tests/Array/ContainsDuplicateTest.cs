using DataStructures.Array;
using Xunit;

namespace DataStructures.Tests.Array;

public class ContainsDuplicateTest
{
    [Theory]
    [InlineData(new [] { 1, 2, 3 }, false)]
    [InlineData(new [] { 1, 2, 2 }, true)]
    public void Verify_Test(int[] array, bool expected)
    {
        var result = ContainsDuplicate.Verify(array);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new [] { 1, 2, 3 }, false)]
    [InlineData(new [] { 1, 2, 2 }, true)]
    public void VerifyWithLinq_Test(int[] array, bool expected)
    {
        var result = ContainsDuplicate.VerifyWithLinq(array);
        
        Assert.Equal(expected, result);
    }
}