// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        IsMagicNumber();
    }
    
    public static void IsMagicNumber()
    {
        var square = 0;
        var temp = 0;
        var ld = 0;
        var add = 0;
        
        for(int i = 1; i <= 50; i++)
        {
            square = i * i;
            temp = square;
            Console.WriteLine(temp);
            while(temp > 0)
            {
                ld = temp % 10;
                add = add + ld;
                temp = temp / 10;
            }
            Console.WriteLine($"{i} = {add}");
            if(add == 9)
            {
                Console.WriteLine(i);
            }
        }
        
        Console.WriteLine("Some Error!.");
    }
}