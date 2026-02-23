// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = {0,0,1,1,1,2,2,3,3,4};
        Console.WriteLine (RemoveDuplicates(a));
    }
    
    public static int RemoveDuplicates(int[] nums) 
    {
        int size = nums.Length;
        int uniqueCount = 0;
        int[] temp = new int[size];
        
        for(int i = 0; i < size; i++)
        {
            temp[i] = nums[i];
        }
        
        for(int i = 0; i < size; i++)
        {
            if(i == 0)
            {
                nums[uniqueCount] = temp[i];
                uniqueCount++;
                continue;
            }
            
            if(temp[i] != temp[i - 1])
            {
                nums[uniqueCount] = temp[i];
                uniqueCount++;
            }
        }
        
        Console.WriteLine(string.Join(",", nums));
        return uniqueCount;
    }
}