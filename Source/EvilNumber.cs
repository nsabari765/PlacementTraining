using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            var (count, binaryNumber) = GetBinaryNumber(number);

            Console.WriteLine($"Is this Evil: {count % 2 == 0}");

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }

    public static (int, byte[]) GetBinaryNumber(int number)
    {
        int evenOnesCount = 0;
        byte[] revBinaryNumber = new byte[32];
        byte[] binaryNumber = new byte[32];
        int index = 0;

        while(number > 0)
        {
            var reminder = (byte)(number % 2);
            revBinaryNumber[index] = reminder;

            if(reminder == 1)
            {
                evenOnesCount++;
            }

            number /= 2;
            index++;
        }

        index = 0;

        for (int i = 31; i >= 0; i--)
        {
            binaryNumber[i] = revBinaryNumber[index];
            index++;
        }

        return (evenOnesCount, binaryNumber);
    }
}