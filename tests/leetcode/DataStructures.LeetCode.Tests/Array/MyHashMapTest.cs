using DataStructures.LeetCode.Array;
using Xunit;

namespace DataStructures.LeetCode.Tests.Array;

public class MyHashMapTest
{
    private readonly MyHashMap _sut;

    public MyHashMapTest()
    {
        _sut = new MyHashMap();
    }
    
    [Theory]
    [InlineData(1, 1, 1)]
    public void Get_Test(int key, int value, int expected)
    {
        _sut.Array[key] = value;

        var result = _sut.Get(key);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(1, -1)]
    public void Get_BadTest(int key, int expected)
    {

        var result = _sut.Get(key);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Put_Test()
    {
        _sut.Put(2, 1);
        
        Assert.Equal(1, _sut.Array[2]);
    }
    
    [Fact]
    public void Remove_Test()
    {
        _sut.Array[1] = 1;
        
        _sut.Remove(1);
        
        Assert.Equal(-1, _sut.Array[1]);
    }
}