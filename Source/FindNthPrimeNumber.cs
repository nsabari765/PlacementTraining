using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        string? userDecision = string.Empty;

        do
        {
            Console.Write("Enter Range:");
            int range = Convert.ToInt32(Console.ReadLine());

            int nthPrime = GetNthPrimeNumber(range);
            Console.WriteLine($"Your Prime = {nthPrime}");

            Console.Write("Do you want to continue (Y/N): ");
            userDecision = Console.ReadLine();

        } while (userDecision.ToLower() == "yes");


        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    private static int GetNthPrimeNumber(int range)
    {
        int number = 2;
        int primeNumber = 0;
        int count = 1;

        while(count <= range)
        {
            if(IsPrime(number))
            {
                primeNumber = number;
                count++;
            }

            number++;
        }

        return primeNumber;
    }

    private static bool IsPrime(int number)
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
}