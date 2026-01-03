using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        var str = Console.ReadLine();

        //Console.WriteLine(str.Length);

        int wordCount = GetWordCount(str);

        if(wordCount == 0)
        {
            Console.WriteLine("Invalid Input, Please Enter a valid Input");
        }
        else
        {
            Console.WriteLine($"Word Counts = {wordCount}");
        }
    }

    public static int GetWordCount(string? str)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if ((int)str[i] == 32)
            {
                if(i == 0 || i > 0 && (int)str[i - 1] == 32)
                {
                    return 0;
                }
            }

            if (((int)str[i] == 32 && (int)str[i - 1] != 32)
                || (str[i] != 32 && i == str.Length - 1))
            {
                count++;
            }
        }

        return count;
    }
}