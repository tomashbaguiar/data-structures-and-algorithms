namespace DataStructures.LeetCode.Array;

public class MyHashMap
{
    public int[] Array { get; }

    public MyHashMap()
    {
        var n = (int) Math.Pow(10, 6) + 1;
        Array = new int[n];
        for (var i = 0; i < n; i++)
        {
            Array[i] = -1;
        }
    }

    public void Put(int key, int value)
    {
        if (key < Array.Length) Array[key] = value;
    }
    
    public int Get(int key)
    {
        return key >= Array.Length ? -1 : Array[key];
    }
    
    public void Remove(int key)
    {
        if (key < Array.Length) Array[key] = -1;
    }
}