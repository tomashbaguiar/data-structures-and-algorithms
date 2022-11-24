namespace DataStructures.Array;

public static class MergeSortedArrays
{
    public static void MergeBruteForce(int[] array1, int m, int[] array2, int n)
    {
        var k = 0;
        var len = array1.Length;
        for (var i = 0; i < len; i++)
        {
            if (k < n && i >= m - 1 && array1[i] == 0)
            {
                array1[i] = array2[k++];
            }
        }

        for (var i = 0; i < len - 1; i++)
        {
            for (var j = 0; j < len - 1; j++)
            {
                if (array1[j] > array1[j + 1])
                {
                    (array1[j], array1[j + 1]) = (array1[j + 1], array1[j]);
                }
            }
        }
    }

    public static void Merge(int[] array1, int m, int[] array2, int n)
    {
        var arr1 = array1.Where((_, i) => i < m).ToList();
        foreach (var num in array2)
        {
            var place = arr1.Count(i => i < num);
            arr1.Insert(place, num);
        }

        for (var i = 0; i < arr1.Count; i++)
        {
            array1[i] = arr1[i];
        }
    }
}