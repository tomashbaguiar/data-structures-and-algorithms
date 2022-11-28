namespace DataStructures.LeetCode.Array;

public static class IntersectionOfTwoArrays
{
    public static int[] IntersectHashTable(int[] array1, int[] array2)
    {
        var ordered1 = array1.OrderBy(c => c).ToArray();
        var ordered2 = array2.OrderBy(c => c).ToArray();
        
        return ordered1.Length > ordered2.Length
            ? GetIntersection(ordered1, ordered2).ToArray()
            : GetIntersection(ordered2, ordered1).ToArray();
    }

    private static IEnumerable<int> GetIntersection(int[] array1, int[] array2)
    {
        var hash = new Dictionary<int, int>();
        for (var i = 0; i < array1.Length; i++)
        {
            hash.Add(i, array1[i]);
        }

        var lastInd = -1;
        foreach (var item in array2)
        {
            if (!hash.ContainsValue(item)) continue;
            var kv = hash.Where(entry => entry.Value == item && entry.Key > lastInd)
                .ToList();
            if (!kv.Any()) continue;
            
            lastInd = kv.First().Key;
            yield return item;
        }
    }
}