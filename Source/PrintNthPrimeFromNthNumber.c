using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        Console.Write("Enter the nth Number:");
        int n = Convert.ToInt32(Console.ReadLine());

        int prime = 0, primeCount = 1, count = n;

        while(primeCount <= count)
        {
            if(IsPrime(n))
            {
                prime = n;
                primeCount++;
            }

            n++;
        }

        Console.WriteLine($"The nth Prime Number from nth Number is: {prime}");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static bool IsPrime(int number)
    {
        int count = 0;

        for(int i = 1; i <= number; i++)
        {
            if(number != 1 && number != 0 && number % i == 0)
            {
                count++;
            }
        }

        return count == 2;
    }
}