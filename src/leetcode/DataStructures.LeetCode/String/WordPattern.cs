namespace DataStructures.LeetCode.String;

public static class WordPattern
{
    public static bool Match(string pattern, string s)
    {
        var p = pattern.ToArray();
        var split = s.Split(' ');
        if (split.Length != p.Length) return false;
        
        var dictPat = new Dictionary<char, string>();
        for (var i = 0; i < split.Length; i++)
        {
            var key = p[i];
            var val = split[i];
            var contains = dictPat.ContainsKey(key);
            if (!contains && dictPat.ContainsValue(val)) return false;
            if (contains && dictPat[key] != val) return false;
            if (!contains) dictPat.Add(key, val);
        }

        return true;
    }
}