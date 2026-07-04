public class HelloWorld
{
    public static void Main(string[] args)
    {
        //int[] ratings = { 1, 3, 2, 2, 1 };
        //int[] ratings = { 1, 2, 87, 87, 87, 2, 1 };
        int[] ratings = { 0, 1, 2, 5, 3, 2, 7 };
        Console.WriteLine("Max No. Of Candies = {0}", Candy(ratings));
    }

    public static int Candy(int[] ratings)
    {
        int childrendSize = ratings.Length;

        if (childrendSize == 1)
        {
            return 1;
        }

        int[] candies = new int[childrendSize];
        int pNum, cNum;

        //Left to Right

        for (int i = 1; i < childrendSize; i++)
        {
            pNum = ratings[i - 1];
            cNum = ratings[i];
            bool isFirstIndex = i - 1 == 0;

            if (pNum < cNum)
            {
                if (!isFirstIndex)
                {
                    candies[i] = candies[i - 1] + 1;
                }
                else
                {
                    candies[i - 1] = 1;
                    candies[i] = 2;
                }
            }
            else if (pNum == cNum)
            {
                candies[i] = 1;
            }
            else
            {
                if (!isFirstIndex)
                {
                    candies[i] = 1;
                }
                else
                {
                    candies[i - 1] = 2;
                    candies[i] = 1;
                }
            }
        }

        Console.WriteLine(string.Join(" ", candies));

        //Right to Left

        for (int i = childrendSize - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1])
            {
                candies[i] = candies[i] <= candies[i + 1]
                    ? candies[i + 1] + 1
                    : (candies[i + 1] + 1) == candies[i]
                        ? candies[i] : candies[i + 1] + 1;
            }
            else if (ratings[i] == ratings[i + 1])
            {
                candies[i] = 1;
            }
            else
            {
                if (candies[i] >= candies[i + 1])
                {
                    candies[i + 1] = candies[i] + 1;
                }
            }
        }

        Console.WriteLine(string.Join(" ", candies));

        return candies.Sum(x => x);
    }
}