// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = {121, 11, 34, 55, 77};
        a = ReverseArray(a);
        
        Console.Write(string.Join(" ", a));
    }
    
    public static int[] ReverseArray(int[] a)
    {
        int size = a.Length;
        int temp = 0, x = 0, y = size - 1;
        int half = size / 2;
        
        for(int i = 0; i <= half; i++)
        {
            temp = a[x];
            a[x] = a[y];
            a[y] = temp;
            
            Console.WriteLine(x + "=" + a[x]);
            Console.WriteLine(y + "=" + a[y]);
            
            if(half > x)
                x++;
                
            if(half < y)
                y--;
            
            Console.Write("\n");
        }
        
        return a;
    }
}