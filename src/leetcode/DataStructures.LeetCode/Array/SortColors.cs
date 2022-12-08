namespace DataStructures.LeetCode.Array;

public static class SortColors
{
    public static void Sort(int[] array)
    {
        var n = array.Length;
        var low = 0;
        var high = n - 1;
        while (high > 0)
        {
            if (array[low] > array[high]) (array[low], array[high]) = (array[high], array[low]);
            
            if (high == low + 1)
            {
                low = 0;
                high--;
                continue;
            }

            low++;
        }
    }
}