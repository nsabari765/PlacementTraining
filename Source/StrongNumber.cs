using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        Console.Write("Enter a number to check if it is a Strong: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIs Strong: " + IsStrong(number));

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static bool IsStrong(int number)
    {
        int ld = 0, sum = 0, mul = 1, temp = number;

        while(temp > 0)
        {
            ld = temp % 10;

            for(int i = ld; i >= 2; i--)
            {
                mul = mul * i;
            }

            sum = sum + mul;
            mul = 1;
            temp = temp / 10;
        }

        return sum == number;
    }
}