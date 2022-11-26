namespace DataStructures.Array;

public static class TwoSum
{
    public static int[] TwoSumBruteForce(int[] array, int target)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var pivot = array[i];
            for (var j = i + 1; j < array.Length; j++)
            {
                var curr = array[j];
                if (curr + pivot == target)
                {
                    return new[] { i, j };
                }
            }
        }

        return new int[] { };
    }

    public static int[] TwoSumHashTable(int[] array, int target)
    {
        var hash = new Dictionary<int, int>();
        for (var i = 0; i < array.Length; i++)
        {
            var curr = array[i];
            var diff = target - curr;
            if (hash.ContainsKey(diff))
            {
                var index = hash[diff];
                return new[] { index, i };
            }
            
            if (hash.ContainsKey(curr)) continue;
            hash.Add(curr, i);
        }

        return new int[] { };
    }
}