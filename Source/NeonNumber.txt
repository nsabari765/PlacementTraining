// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Is this Neon Number: {0}", IsNeonNumber(89));
    }
    
    public static bool IsNeonNumber(int number)
    {
        var square = number * number;
        var temp = number;
        var ld = 0;
        var add = 0;
        
        while(temp > 0)
        {
           ld  = temp % 10;
           add = add + ld;
           temp = temp / 10;
        }
        
        if(add == number)
        {
            return true;
        }
        
        return false;
    }
}