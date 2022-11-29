namespace DevTraining.Codility.Arrays;

public static class CyclicRotation
{
    public static int[] Solution(int[] array, int k)
    {
        var len = array.Length;
        if (len == 0) return Array.Empty<int>();

        var queue = new Queue<int>();
        for (var i = len - 1; i >= 0; i--) queue.Enqueue(array[i]);

        for (var i = 0; i < k; i++)
        {
            var e = queue.Dequeue();
            queue.Enqueue(e);
        }

        return queue.Reverse().ToArray();
    }
}