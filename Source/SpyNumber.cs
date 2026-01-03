// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number: ");
        var input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Is this Spy: {0}", IsSpyNumber(input));
    }
    
    public static bool IsSpyNumber(int number)
    {
        var temp = number;
        var digit = 0;
        int add = 0, mul = 1;
        
        while(temp > 0)
        {
            digit = temp % 10;
            add = add + digit;
            mul = mul * digit;
            temp = temp / 10;
        }
        
        return add == mul;
    }
}