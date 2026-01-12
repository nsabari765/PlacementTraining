// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int half = n/2, sum = 1;
        int[] factor = new int[half];
        
        for(int i = 2; i <= half; i++)
        {
            if(n % i == 0)
            {
                factor[i-2] = i;
            }
        }
        
        Console.WriteLine(string.Join(",", factor));
    }
}