int MaxProfit(int[] prices)
{
    var maxProfit = new int[] { 0, 0 };

    for (var i = 0; i < prices.Length; i++)
    {
        for (var j = i + 1; j < prices.Length; j++)
        {
            if (i == j)
                continue;

            if (prices[i] < prices[j])
            {
                var m = maxProfit[0];
                var n = maxProfit[1];

                if (prices[j] - prices[i] > prices[n] - prices[m] || (m == 0 && n == 0))
                {
                    maxProfit[0] = i;
                    maxProfit[1] = j;
                }
            }
        }
    }

    if (maxProfit[0] == 0 && maxProfit[1] == 0)
        return 0;

    return maxProfit[1];
}

Console.WriteLine(MaxProfit([7, 1, 5, 3, 6, 4]));
Console.WriteLine(MaxProfit([7, 6, 4, 3, 1]));