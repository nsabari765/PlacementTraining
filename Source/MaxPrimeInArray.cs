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
            int maxPrime = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter {i}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < size; i++)
            {
                if (IsPrime(numbers[i]))
                {
                    if(maxPrime < numbers[i])
                    {
                        maxPrime = numbers[i]; 
                    }
                }
            }

            Console.WriteLine("Max Prime Number in the array = " + maxPrime);
            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static bool IsPrime(int number)
    {
        int half = number / 2, count = 0;

        for(int i = 1; i <= half; i++)
        {
            if(number % i == 0)
            {
                count++;
            }
        }

        return count == 1;
    }
}