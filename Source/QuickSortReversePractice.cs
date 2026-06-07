using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the array size: ");

        int size = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter " + i + " value: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n\nOriginal array:" + string.Join(",", nums));

        var stopWatch = Stopwatch.StartNew();

        QuickSortInReverse(nums, 0, nums.Length - 1);

        Console.WriteLine("After Sorting: " + string.Join(",", nums));

        Console.WriteLine("Time Taken: " + stopWatch.ElapsedMilliseconds / 60 + "s");

        stopWatch.Stop();
    }

    public static void QuickSortInReverse(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(arr, low, high);

            QuickSortInReverse(arr, low, partitionIndex - 1);
            QuickSortInReverse(arr, partitionIndex + 1, high);
        }
    }

    public static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[low];
        int i = low, j = high;

        //Inside the while loop just change the < and > symbol for (3 if conditions)
        while (i < j)
        {
            if (arr[i] > pivot)
            {
                i++;
            }

            if (arr[j] < pivot)
            {
                j--;
            }

            if (arr[i] < arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        return j;
    }
}