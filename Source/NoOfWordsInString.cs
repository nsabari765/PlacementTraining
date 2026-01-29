using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            int wordCount = 0;

            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            for(int i = 0; i < input.Length; i++)
            {
                if((i > 0 && input[i - 1] != 32 && input[i] == 32))
                {
                    wordCount++;
                }
            }

            if (input[input.Length - 1] != 32)
            {
                wordCount++;
            }

            Console.WriteLine($"The no. of words in the given sentence is: {wordCount}");

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}