using System.Diagnostics;

//This Problem is Solve using Boyer-Moore Voting Algorithm

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 3, 3, 3, 2, 3, 2 };
        Console.WriteLine(MajorityElement(a));
    }

    public static int MajorityElement(int[] nums)
    {
        int size = nums.Length;
        int element = nums[0];
        int counter = 1;

        for (int i = 1; i < size; i++)
        {
            if (nums[i] == element)
            {
                counter++;
            }
            else
            {
                counter--;

                if (counter == 0)
                {
                    counter = 1;
                    element = nums[i];
                }
            }
        }

        return element;
    }
}