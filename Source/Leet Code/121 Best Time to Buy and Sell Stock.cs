using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 0 };
        Console.WriteLine($"Profit: {MaxProfit(a)}");
    }

    public static int MaxProfit(int[] prices)
    {
        int size = prices.Length;
        int buy = prices[0], bd = 0, profit = 0, sell = 0;

        if (size > 1)
        {
            for (int i = 1; i < size; i++)
            {
                if (buy > prices[i])
                {
                    buy = prices[i];
                    bd = i;
                }                
                else if (profit < (prices[i] - buy))
                {
                    sell = prices[i];
                    profit = sell - buy;
                }
            }

            return profit;
        }

        return 0;
    }
}