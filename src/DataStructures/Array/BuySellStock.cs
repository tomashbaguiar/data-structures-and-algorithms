namespace DataStructures.Array;

public static class BuySellStock
{
    public static int MaxProfitBruteForce(int[] prices)
    {
        var maxProfit = 0;
        for (var i = 0; i < prices.Length; i++)
        {
            var pivot = prices[i];
            for (var j = i + 1; j < prices.Length; j++)
            {
                var curr = prices[j];
                var profit = curr - pivot;
                maxProfit = profit > maxProfit ? profit : maxProfit;
            }
        }

        return maxProfit;
    }

    public static int MaxProfitDynamicProgramming(IEnumerable<int> prices)
    {
        var maxProfit = 0;
        var least = int.MaxValue;
        foreach (var curr in prices)
        {
            least = curr < least ? curr : least;
            var profit = curr - least;
            maxProfit = profit > maxProfit ? profit : maxProfit;
        }

        return maxProfit;
    }
}