using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        Console.Write("Enter the nth Number:");
        int n = Convert.ToInt32(Console.ReadLine());

        int primeCount = 0, count = n;
        int[] prime = new int[count];
        
        while(primeCount < count)
        {
            if(IsPrime(n))
            {
                prime[primeCount] = n;
                primeCount++;
            }

            n++;
        }

        Console.WriteLine($"The n Prime Numbers are: {string.Join(",", prime)}");

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