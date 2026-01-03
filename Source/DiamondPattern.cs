// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 41;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(i - j == n/2 || i + j == 3*(n/2)
                    || i + j == n/2 && i > n/4
                    || i - j == -(n/2) && i > n/4
                   || i == n/4 && j >= n/4 && j <= 3*(n/4))
                {
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            
            Console.Write("\n");
        }
    }
}