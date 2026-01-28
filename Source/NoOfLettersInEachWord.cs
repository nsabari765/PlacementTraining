using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            int letterCount = 0;
            int wordCount = 0;

            Console.Write("Enter a string: ");
            var input = Console.ReadLine();
            int size = input.Length;

            for(int i = 0; i < size; i++)
            {
                if (input[i] != 32)
                {
                    letterCount++;
                }

                if(i > 0 && input[i - 1] != 32 && input[i] == 32)
                {
                    Console.WriteLine($"{++wordCount} is {letterCount}");
                    letterCount = 0;
                }
            }

            if (input[size - 1] != 32)
            {
                Console.WriteLine($"{++wordCount} is {letterCount}");
            }

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}