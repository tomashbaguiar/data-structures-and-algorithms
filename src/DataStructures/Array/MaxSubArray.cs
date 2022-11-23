namespace DataStructures.Array;

public static class MaxSubArray
{
    public static int ResolveDivideAndConquer(int[] array)
    {
        return FindMaxSubarray(array, 0, array.Length - 1).Item3;
    }

    private static (int, int, int) FindMaxSubarray(int[] array, int low, int high)
    {
        if (high == low)
        {
            return (low, high, array[low]);
        }

        var mid = (low + high) / 2;
        var (leftLow, leftHigh, leftSum) = FindMaxSubarray(array, low, mid);
        var (rightLow, rightHigh, rightSum) = FindMaxSubarray(array, mid + 1, high);
        var (crossLow, crossHigh, crossSum) = FindMaxCrossingSubarray(array, low, mid, high);

        if (leftSum >= rightSum && leftSum >= crossSum)
        {
            return (leftLow, leftHigh, leftSum);
        }

        if (rightSum >= leftSum && rightSum >= crossSum)
        {
            return (rightLow, rightHigh, rightSum);
        }

        return (crossLow, crossHigh, crossSum);
    }

    private static (int, int, int) FindMaxCrossingSubarray(int[] array, int low, int mid, int high)
    {
        var leftSum = int.MinValue;
        var sum = 0;
        var maxLeft = 0;

        for (var i = mid; i >= low; i--)
        {
            sum += array[i];
            if (sum <= leftSum) continue;
            leftSum = sum;
            maxLeft = i;
        }

        sum = 0;
        var rightSum = int.MinValue;
        var maxRight = 0;

        for (var i = mid + 1; i <= high; i++)
        {
            sum += array[i];
            if (sum <= rightSum) continue;
            rightSum = sum;
            maxRight = i;
        }

        return (maxLeft, maxRight, leftSum + rightSum);
    }
}