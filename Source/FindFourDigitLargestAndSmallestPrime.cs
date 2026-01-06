using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        var smallestPrime = GetSmallestFourDigitPrimeNumber();
        var largestPrime = GetLargestFourDigitPrimeNumber();
        var smallAllFourPrime = GetSmallestAllFourDigitPrimeNumber();
        var largeAllFourPrime = GetLargestAllFourDigitPrimeNumber();

        Console.WriteLine("The smallest four-digit prime number is: " + smallestPrime);
        Console.WriteLine("The largest four-digit prime number is: " + largestPrime);
        Console.WriteLine("The smallest all four-digit prime number is: " + smallAllFourPrime);
        Console.WriteLine("The largest all four-digit prime number is: " + largeAllFourPrime);

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static int GetSmallestFourDigitPrimeNumber()
    {
        int start = 1000;
        int end = 9999;
        int smallestPrime = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                smallestPrime = i;
                break;
            }
        }

        return smallestPrime;
    }

    public static int GetLargestFourDigitPrimeNumber()
    {
        int start = 1000;
        int end = 9999;
        int largestPrime = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                if (largestPrime < i)
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
        int smallest = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i) && IsAllDigitsPrime(i))
            {
                smallest = i;
                break;
            }
        }

        return smallest;
    }

    public static int GetLargestAllFourDigitPrimeNumber()
    {
        int start = 1000;
        int end = 9999;
        int largest = 0;

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i) && IsAllDigitsPrime(i))
            {
                if (largest < i)
                {
                    largest = i;
                }
            }
        }

        return largest;
    }

    public static bool IsPrime(int number)
    {
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
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

        while (temp > 0)
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