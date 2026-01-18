using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            int[] a = { 2, 3, 7, 9, 11, 1, 87 };
            int size = a.Length, halfSize = size / 2;
            int max = 0, left = 1, right = size - 2, lmax = a[0], rmax = a[size - 1];

            while(left <= right)
            {
                if(lmax < a[left])
                {
                    lmax = a[left];
                }

                if(rmax < a[right])
                {
                    rmax = a[right];
                }

                right--;
                left++;
            }

            max = Math.Max(lmax, rmax);

            Console.WriteLine($"Maximum value in the array is: {max}");

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}