using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        Console.Write("Enter a number to check if it is a Automorphic: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIs Automorphic: " + IsAutomorphic(number));

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        int temp = number, numLength = 0, lastNDigits = 0, ld = 0, rev = 0;

        while(temp > 0)
        {
            temp = temp / 10;
            numLength++;
        }

        int sqTemp = square;

        for(int i = 0; i < numLength; i++)
        {
            ld = sqTemp % 10;
            lastNDigits = lastNDigits * 10 + ld;
            sqTemp = sqTemp / 10;
        }

        while(lastNDigits > 0)
        {
            ld = lastNDigits % 10;
            rev = rev * 10 + ld;
            lastNDigits = lastNDigits / 10;
        }

        Console.WriteLine("Square = " + square);

        return rev == number;
    }
}