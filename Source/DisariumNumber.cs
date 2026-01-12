using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        Console.Write("Enter a number to check if it is a Disarium: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIs Disarium: " + IsDisarium(number));

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static bool IsDisarium(int number)
    {
        int numLength = 0, ld = 0, sum = 0, mul = 1, temp = number;

        //Find Number Length

        while(temp > 0)
        {
            temp = temp / 10;
            numLength++;
        }

        temp = number;

        while(temp > 0)
        {
            ld = temp % 10;

            for(int i = numLength; i >= 1; i--)
            {
                mul = mul * ld;
            }

            sum = sum + mul;
            mul = 1;
            numLength--;
            temp = temp / 10;
        }

        return sum == number;
    }
}