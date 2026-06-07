using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] nums = { 10, 7, 8, 9, 1, 5 };

        Stopwatch stopwatch = Stopwatch.StartNew();

        QuickSort(nums, 0, nums.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", nums));

        stopwatch.Stop();

        Console.WriteLine("Time taken: " + stopwatch.ElapsedMilliseconds + " ms");
    }

    public static void QuickSort(int[] nums, int lowest, int highest)
    {
        if (lowest < highest)
        {
            int partitionIndex = Partition(nums, lowest, highest);

            QuickSort(nums, lowest, partitionIndex - 1);
            QuickSort(nums, partitionIndex + 1, highest);
        }
    }

    private static int Partition(int[] nums, int lowest, int highest)
    {
        int pivot = nums[lowest];
        int i = lowest, j = highest, temp = 0;

        while (i < j)
        {
            if (nums[i] < pivot)
            {
                i++;
            }

            if (nums[j] > pivot)
            {
                j--;
            }

            if (nums[i] > nums[j])
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }

        return j;
    }
}