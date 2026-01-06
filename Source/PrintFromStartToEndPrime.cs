using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        Console.Write("Enter Start Range:");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter End Range:");
        int end = Convert.ToInt32(Console.ReadLine());

        PrintStartToEndPrime(start, end);

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    private static void PrintStartToEndPrime(int start, int end)
    {
        int count = 0;

        for(int i = start; i <= end; i++)
        {
            if(IsPrime(i))
            {
                count++;
                Console.WriteLine($"\t{count}) {i}");
            }
        }

        Console.WriteLine($"Total Prime Numbers between {start} and {end} is: {count}");
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
}