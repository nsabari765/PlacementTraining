// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Put the Weight: ");
        var weight = Convert.ToInt32(Console.ReadLine());
        
        if(weight < 0)
        {
            Console.WriteLine("Invalid Input");
        }
        else if(weight > 7000)
        {
             Console.WriteLine("Overloaded");
        }
        else
        {
            var timeEst = GetTimeLimit(weight);
            Console.WriteLine(timeEst);
        }
        
    }
    
    public static int GetTimeLimit(int weight)
    {
        if(weight > 0 && weight <= 2000){
            return 25;
        }
        else if(weight > 2000 && weight <= 4000)
        {
            return 35;
        }
        else if(weight > 4000 && weight <= 7000)
        {
            return 45;
        }
        
        return 0;
    }
}