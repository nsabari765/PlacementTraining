using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        var str = Console.ReadLine();

        var vowelCount = GetVowelCount(str);

        Console.WriteLine($"Vowel Counts = {vowelCount}");
    }

    public static int GetVowelCount(string? str)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i'
                || str[i] == 'o' || str[i] == 'u'
                || str[i] == 'A' || str[i] == 'E' || str[i] == 'O'
                || str[i] == 'O' || str[i] == 'U')
            {
                count++;
            }
        }

        return count;
    }
}