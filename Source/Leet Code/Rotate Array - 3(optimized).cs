using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2 };
        Rotate(a, 7);
        Console.WriteLine(string.Join(",", a));
    }

    public static void Rotate(int[] nums, int k)
    {
        int size = nums.Length;

        if (size == 0 || k <= 0 || size == 1)
        {
            return;
        }

        k = k % size;

        //Reverse Array

        ReverseArray(nums, 0, size - 1);

        //Reverse first k elements

        ReverseArray(nums, 0, k - 1);

        //Reverse last n-k elements

        ReverseArray(nums, k, size - 1);
    }

    private static void ReverseArray(int[] nums, int start, int end)
    {
        int temp = 0;

        while (start < end)
        {
            temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}