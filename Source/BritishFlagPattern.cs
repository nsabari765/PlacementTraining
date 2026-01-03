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
                if(i == 0 || j == 0
                    || i == n - 1 || j == n - 1
                    || i == n/2 || i == j 
                    || i + j == n - 1 || j == n/2)
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