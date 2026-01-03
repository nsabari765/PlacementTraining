// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsSpecialNumber(49));
    }
    
    public static string IsSpecialNumber(int number)
    {
        int temp = number;
        var add = 0;
        var mul = 1;
        var digit = 0;
        
        while(temp > 0)
        {
            digit = temp % 10;
            
            add = add + digit;
            mul = mul * digit;
            
            temp = temp / 10;
        }
        
        return (add + mul) == number
            ? "It is a Special Number"
            : "It is not a Special Number";
    }
}