using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            string resultString = ConvertCase(inputString);

            Console.WriteLine($"Converted String: {resultString}");

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static string ConvertCase(string a)
    {
        string b = string.Empty;

        for(int i = 0; i < a.Length; i++)
        {
            if (a[i] != 32 && a[i] >= 97 && a[i] <= 123)
            {
                b += (char)(a[i] - 32);
            }
            else if (a[i] != 32 && a[i] >= 65 && a[i] <= 91)
            {
                b += (char)(a[i] + 32);
            }
            else
            {
                b += a[i];
            }
        }

        return b;
    }
}