using System.Collections;

namespace DataStructures.String;

public static class RansomNote
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var hash = new Hashtable();
        foreach (var c in magazine)
        {
            var count = 1;
            if (hash.ContainsKey(c))
            {
                count += (int)hash[c];
                hash.Remove(c);
            }
            
            hash.Add(c, count);
        }

        foreach (var c in ransomNote)
        {
            if (!hash.ContainsKey(c)) return false;

            var count = (int)hash[c] - 1;
            hash.Remove(c);
            if (count > 0) hash.Add(c, count);
        }

        return true;
    }
}