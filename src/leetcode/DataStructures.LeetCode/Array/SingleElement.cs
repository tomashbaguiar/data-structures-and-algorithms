namespace DataStructures.LeetCode.Array;

public static class SingleElement
{
    public static int Find(int[] array)
    {
        if (array.Length == 0) return 0;
        
        var hash = new Dictionary<int, int>();
        foreach (var e in array)
        {
            if (!hash.ContainsKey(e))
            {
                hash.Add(e, 1);
                continue;
            }
            
            hash[e]++;
        }

        return hash.First(e => e.Value == 1).Key;
    }
}