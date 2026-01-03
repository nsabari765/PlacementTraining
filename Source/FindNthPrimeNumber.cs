// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
    
    public int GetNPrimeNumber(int n)
    {
        int primeRange = 0;
        var count = 0;
        var temp = 2;
        
        while(temp <= n)
        {
            for(int i = 1; i <= temp; i++)
            {
                if((temp % i) == 0)
                {
                    count++;
                }
            }
            
            if(count == 2)
            {
                primeRange++;
                temp = 
            }
        }
    }
}