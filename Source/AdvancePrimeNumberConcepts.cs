using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        var smallestPrime = GetSmallestFourDigitPrimeNumber();
        var largestPrime = GetLargestFourDigitPrimeNumber();

        Console.WriteLine("The smallest four-digit prime number is: " + smallestPrime);
        Console.WriteLine("The largest four-digit prime number is: " + largestPrime);

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static int GetSmallestFourDigitPrimeNumber()
    {
        int start = 1000;
        int end = 9999;
        int smallestPrime = 9999;

        for(int i = start; i <= end; i++)
        {
            if(IsPrime(i))
            {
                if(i < smallestPrime)
                {
                    smallestPrime = i;
                }
            }
        }

        return smallestPrime;
    }

    public static int GetLargestFourDigitPrimeNumber()
    {
        int start = 1000;
        int end = 9999;
        int largestPrime = 1000;

        for(int i = start; i <= end; i++)
        {
            if(IsPrime(i))
            {
                if(i > largestPrime)
                {
                    largestPrime = i;
                }
            }
        }

        return largestPrime;
    }

    public static int GetSmallestAllFourDigitPrimeNumber()
    {
        int start = 1000;
        int end = 9999;
        int smallest = 9999;

        for(int i = start; i <= end; i++)
        {
            if(IsPrime(i) && IsAllDigitsPrime(i))
            {
                if(smallest > i)
                {
                    smallest = i;
                }
            }
        }

    }

    public static bool IsPrime(int number)
    {
        int count = 0;

        for(int i = 1; i <= number; i++)
        {
            if(number % i == 0)
            {
                count++;
            }
        }

        return count == 2;
    }

    public static bool IsAllDigitsPrime(int number)
    {
        int count = 0, lastDigit = 0;
        int temp = number;
        int length = 0;

        while(temp > 0)
        {
            lastDigit = temp % 10;

            if (lastDigit == 2 || lastDigit == 3 
                || lastDigit == 5 || lastDigit == 7)
            {
                count++;
            }

            temp = temp / 10;
            length++;
        }

        return count == length;
    }
}