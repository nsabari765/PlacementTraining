using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            int[] a = {1, 2, 3, 4, 5 };
            int size = a.Length - 1, tempSize = size;
            Console.Write("Enter No. Of Positions to right shift: ");
            int noOfPulses = Convert.ToInt32(Console.ReadLine()), tempPulses = noOfPulses - 1,shiftPosition = 0;
            int[] temp = new int[noOfPulses];

            while(tempPulses >= 0)
            {
                temp[tempPulses] = a[tempSize];
                tempPulses--;
                tempSize--;
            }

            tempPulses = noOfPulses - 1;

            for (int i = 0; i <= size; i++)
            {
                shiftPosition = size - i - noOfPulses;

                if(shiftPosition >= 0)
                {
                    a[size-i] = a[shiftPosition];
                }
            }

            Console.WriteLine("Before Shift: " + string.Join(" ", a));

            for(int i = 0; i < noOfPulses; i++)
            {
                a[i] = temp[i];
            }

            Console.WriteLine("After Shift: " + string.Join(" ", a));
            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}