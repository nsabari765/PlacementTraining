// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = {0,0,1,1,1,1,2,3,3};
        Console.WriteLine(RemoveDuplicates(a));
    }
    
    public static int RemoveDuplicates(int[] nums) {
        int size = nums.Length;
        int index = 0;
        
        for(int i = 0; i < size; i++)
        {
            if(i == 0 || i == 1)
            {
                nums[index] = nums[i];
                index++;
            }
            else if(nums[i] != nums[index - 2])
            {
                nums[index] = nums[i];
                index++;
            }
        }
        
        Console.WriteLine(string.Join(",", nums));
        return index;
    }
}