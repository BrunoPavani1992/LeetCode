int MaxProfit(int[] prices)
{
    var max = 0;
    var min = prices[0];

    for (var i = 1; i < prices.Length; i++)
    {
        if (prices[i] < min) min = prices[i];
        else if (prices[i] - min > max) max = prices[i] - min;
    }

    return max;
}

Console.WriteLine(MaxProfit([7, 1, 5, 3, 6, 4]));
Console.WriteLine(MaxProfit([7, 6, 4, 3, 1]));