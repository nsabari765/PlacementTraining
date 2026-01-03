// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsArmStrongNumber(153));
    }
    
    public static bool IsArmStrongNumber(int number)
    {
        var length = GetNumberLength(number);
        var temp = number;
        int ld = 0, add = 0;
        var result = 1;
        
        while(temp > 0)
        {
            ld = temp % 10;
            add = add + GetNumberByPower(ld, length);
            temp = temp / 10;
        }
        
        return add == number;
    }
	
	public static int GetNumberLength(int number)
    {
        var length = 0;
        
        while(number > 0)
        {
            number = number / 10;
            length++;
        }
        
        return length;
    }
    
    public static int GetNumberByPower(int number, int power)
    {
        int result = 1;
        
        for(int i = 1; i <= power; i++)
        {
            result = result * number;
        }
        
        return result;
    }       
}