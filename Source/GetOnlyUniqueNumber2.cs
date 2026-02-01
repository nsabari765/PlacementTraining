using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine()); 
            int reverse = 0, actual = 0, temp = a, ld;

            while(temp > 0)
            {
                ld = temp % 10;
                reverse = !IsNumberRepeat(ld, reverse) 
                    ? reverse * 10 + ld
                    : reverse;
                temp /= 10;
            }

            while(reverse > 0)
            {
                ld = reverse % 10;
                actual = actual * 10 + ld;
                reverse /= 10;
            }

            Console.WriteLine($"The number without duplicate = {actual}");

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static bool IsNumberRepeat(int number, int wholeNumber)
    {
        int ld = 0;

        while(wholeNumber > 0)
        {
            ld = wholeNumber % 10;

            if (ld == number)
            {
                return true;
            }

            wholeNumber /= 10;
        }

        return false;
    }
}