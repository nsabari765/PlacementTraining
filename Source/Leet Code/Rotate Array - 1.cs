using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { -1, -100, 3, 99 };
        Rotate(a, 2);
        Console.WriteLine(string.Join(",", a));
    }

    public static void Rotate(int[] nums, int k)
    {
        int size = nums.Length;

        int size = nums.Length;

        for (int i = 0; i < k; i++)
        {
            int ld = nums[size - 1];

            for (int j = size - 1; j >= 0; j--)
            {
                nums[j] = j == 0 ? ld : nums[j - 1];
            }
        }
    }
}