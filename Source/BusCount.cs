// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("The buses required are {0}", GetBusCount(51));
    }
    
    public static int GetBusCount(int passengers)
    {
        var bus = passengers / 50;
        var extraBus = passengers % 50;
        bus = extraBus != 0 ? bus + extraBus : bus;
        
        return bus;
    }
}