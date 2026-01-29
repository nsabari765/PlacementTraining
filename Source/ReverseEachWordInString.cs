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
            string input = Console.ReadLine();
            string reversedString = ReverseString(input);
            Console.WriteLine($"Reversed String: {reversedString}");

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static string ReverseString(string input)
    {
        Stack<char> charStack = new Stack<char>();
        string result = string.Empty;
        int size = input.Length;
        
        for(int i = 0; i < size; i++)
        {
            if (input[i] != 32)
            {
                charStack.Push(input[i]);
            }
            else
            {
                while(charStack.Count > 0)
                {
                    result += charStack.Pop();
                }

                result += ' ';
            }
        }

        while(charStack.Count > 0)
        {
            result += charStack.Pop();
        }

        return result;
    }
}