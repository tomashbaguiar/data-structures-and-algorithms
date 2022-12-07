namespace DataStructures.LeetCode.Array;

public static class MajorityElement
{
    public static int Find(int[] array)
    {
        if (array.Length == 1) return array[0];
        
        var hash = new Dictionary<int, int>();
        var max = 0;
        var maj = array.First();
        foreach (var e in array)
        {
            if (hash.ContainsKey(e))
            {
                if (max >= ++hash[e]) continue;
                max = hash[e];
                maj = e;
                continue;
            }

            hash.Add(e, 1);
        }

        return maj;
    }
}