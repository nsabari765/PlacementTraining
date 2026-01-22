using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int noOfUnique = 0;

            for(int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < size; i++)
            {
                int count = 0;

                for (int j = 0; j < size; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }

                noOfUnique += count == 1 ? 1 : 0;
            }

            Console.WriteLine($"Number of unique elements in the array: {noOfUnique}");

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}