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
            int[] numbers = new int[size];
            int duplicateCount = 0, numberCount = 0;

            for(int i = 0; i < size; i++)
            {
                Console.Write($"Enter {i}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < size; i++)
            {
                numberCount = 0;

                for (int j = 0; j < size; j++)
                {
                    if(i > j && numbers[i] == numbers[j])
                    {
                        break;
                    }
                    else if (numbers[i] == numbers[j])
                    {
                        numberCount++;
                    }
                }

                duplicateCount += numberCount > 1 ? 1 : 0;
            }

            Console.WriteLine($"Number of duplicate elements in the array: {duplicateCount}");

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}