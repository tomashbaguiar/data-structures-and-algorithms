namespace DataStructures.LeetCode.Array;

public static class ThreeSum
{
    public static IList<IList<int>> Solution(int[] nums)
    {
        var sol = new List<IList<int>>();
        if (nums.Length == 0) return sol;

        var hash  = new HashSet<(int, int, int)>();
        var array = nums.OrderBy(c => c)
            .ToArray(); 
        for (var i = 0; i < array.Length - 2; i++)
        {
            var j = i + 1;
            var k = array.Length - 1;
            var x = array[i];
            while (j < k)
            {
                var (y, z) = (array[j], array[k]);
                var sum = x + y + z;
                if (sum == 0)
                {
                    var c = (array[i], array[j++], array[k--]);
                    if (!hash.Contains(c))
                    {
                        hash.Add(c);
                        sol.Add(new List<int> { x, y, z });
                    }
                    continue;
                }

                if (sum > 0)
                {
                    k--;
                    continue;
                }

                j++;
            }
        }
        
        return sol;
    }
}