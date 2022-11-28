using System.Collections;

namespace DataStructures.LeetCode.String;

public static class UniqueChar
{
    public static int First(string s)
    {
        var hash = new Hashtable();
        foreach (var c in s)
        {
            var count = 1;
            if (hash.ContainsKey(c))
            {
                count += (int) hash[c];
                hash.Remove(c);
            }
            
            hash.Add(c, count);
        }

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (hash.ContainsKey(c) && (int)hash[c] == 1) return i;
        }

        return -1;
    }
}