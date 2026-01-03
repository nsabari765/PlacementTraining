// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number: ");
        var input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Is this Pronic: {0}", IsPronicNumber(input));
    }
    
    public static bool IsPronicNumber(int number)
    {
        for(int i = 1; i <= number / 2; i++)
        {
            if((i * (i + 1)) == number)
            {
                return true;
            }
        }
        
        return false;
    }
}