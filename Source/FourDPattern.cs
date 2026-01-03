// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 20;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(i + j <= n - 1 && j >= n/2)
                {
                    Console.Write("1");
                }
                else if(i + j >= n - 1 && i <= n/2)
                {
                    Console.Write("2");
                }
                else if(i + j >= n - 1 && i <= j)
                {
                    Console.Write("3");
                }
                else if(i + j >= n - 1 && j >= n/2)
                {
                    Console.Write("4");
                }
                else if(i + j >= n - 1 && i >= n/2)
                {
                    Console.Write("5");
                }
                else if(i + j <= n - 1 && i >= n/2)
                {
                    Console.Write("6");
                }
                else if(i + j <= n - 1 && i >= j)
                {
                    Console.Write("7");
                }
                else if(i + j <= n - 1 && i <= j)
                {
                    Console.Write("8");
                }
                else{
                    Console.Write(" ");
                }
            }
            
            Console.Write("\n");
        }
    }
}