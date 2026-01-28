using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            int vowelCount = 0;

            Console.Write("Enter a string: ");
            var input = Console.ReadLine();

            for(int i = 0; i < input.Length; i++)
            {
                if (IsVowel(input[i]))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"Number of vowels: {vowelCount}");
            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static bool IsVowel(char letter)
    {
        return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
           letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U';
    }
}