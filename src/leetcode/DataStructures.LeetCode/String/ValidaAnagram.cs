using System.Collections;

namespace DataStructures.LeetCode.String;

public static class ValidaAnagram
{
    public static bool IsValidLinq(string s, string t)
    {
        var sSorted = s.OrderBy(c => c).ToList();
        var tSorted = t.OrderBy(c => c).ToList();

        return sSorted.SequenceEqual(tSorted);
    }

    public static bool IsValid(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        var hash = new Hashtable();
        foreach (var c in t)
        {
            var count = 1;
            if (hash.ContainsKey(c))
            {
                count += (int)hash[c];
                hash.Remove(c);
            }
            
            hash.Add(c, count);
        }

        foreach (var c in s)
        {
            if (!hash.ContainsKey(c)) return false;

            var count = (int)hash[c] - 1;
            hash.Remove(c);
            if (count > 0) hash.Add(c, count);
        }

        return true;
    }
}