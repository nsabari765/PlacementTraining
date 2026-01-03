// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number: ");
        var input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Is this Palindrome Number: {0}", IsPalindrome(input));
    }
    
    public static bool IsPalindrome(int number)
    {
        var temp = number;
        var digit = 0;
        var mod = 0;
        
        while(temp > 0)
        {
            digit = temp % 10;
            mod = (mod * 10) + digit;
            temp = temp / 10;
        }
        
        return mod == number;
    }
}