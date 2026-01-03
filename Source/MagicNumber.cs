// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number: ");
        var input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Is this Magic Number: {0}", IsMagicNumber(input));
    }
    
    public static bool IsMagicNumber(int number)
    {
        var temp = number;
        var digit = 0;
        int add = 0;
        int rev = 0;
        
        while(temp > 0)
        {
            digit = temp % 10;
            add = add + digit;
            temp = temp / 10;
        }
        
        var temp2 = add;
        
        while(temp2 > 0)
        {
            digit = temp2 % 10;
            rev = (rev * 10) + digit;
            temp2 = temp2 / 10;
        }
        
        var response = add * rev;
        
        return response == number;
    }
}