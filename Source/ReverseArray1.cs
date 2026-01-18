using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            Console.Write("Enter Your Array Size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];

            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter Element {0}: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] temp = new int[size];

            int index = 0;

            while (index <= size-1)
            {
                temp[index] = a[size - 1 - index];
                index++;
            }

            index = size - 1;

            while (index >= 0)
            {
                a[index] = temp[index];
                index--;
            }

            Console.WriteLine("Reversed Array = {0}", string.Join(" ", a));

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}