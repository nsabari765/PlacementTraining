using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        Console.Write("Enter a number to check if it is a Perfect Square: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIs Perfect Square: " + IsPerfectSquare(number));

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static bool IsPerfectSquare(int number)
    {
        for (int i = 1; i <= number / 2; i++)
        {
            if(i * i == number)
            {
                return true;
            }
        }

        return false;
    }
}