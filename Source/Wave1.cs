// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 7;
        int space = n-1, star = 1;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
               for(int k = 0; k < n; k++)
               {
                   if(i == k || i + k == n - 1)
                   {
                       Console.Write("*");
                   }
                   else
                   {
                       Console.Write(" ");
                   }
               }
            }
            
            Console.Write("\n");
        }
    }
}