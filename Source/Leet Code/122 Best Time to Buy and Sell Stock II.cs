using System.ComponentModel;
using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //int[] a = { 7, 1, 5, 7, 3, 6, 4 };
        //int[] a = { 7, 1, 5, 3, 6, 4 };
        //int[] a = { 1, 2, 3, 4, 5 };
        //int[] a = { 1, 5, 2, 6, 4, 9 };
        int[] a = { 1, 7, 1, 5, 9, 9 };
        Console.WriteLine($"Profit: {MaxProfit(a)}");
    }

    public static int MaxProfit(int[] prices)
    {
        int size = prices.Length;
        int buy = prices[0], profit = 0, totalProfits = 0;

        if (size > 1)
        {
            for (int i = 1; i < size; i++)
            {
                if (buy > prices[i] || prices[i - 1] > prices[i])
                {
                    buy = prices[i];
                    totalProfits += profit;
                    profit = 0;
                }
                else if (profit < prices[i] - buy)
                {
                    profit = prices[i] - buy;
                }
            }

            if (prices[size - 2] <= prices[size - 1])
            {
                totalProfits += profit;
            }

            return totalProfits;
        }

        return 0;
    }
}