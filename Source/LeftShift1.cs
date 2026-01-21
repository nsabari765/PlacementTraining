using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            int[] a = {1, 2, 3, 4};
            int size = a.Length;

            Console.Write("Enter No. Of Positions to right shift: ");
            int noOfPulses = Convert.ToInt32(Console.ReadLine()), tempPulses = noOfPulses - 1,shiftPosition = 0;

            int[] temp = new int[noOfPulses];
            int noOfEleToLeftShift = size - noOfPulses;
            int index = noOfPulses;

            for(int i = 0; i < noOfPulses; i++)
            {
                temp[i] = a[i];
            }

            for(int i = 0; i < noOfEleToLeftShift; i++)
            {
                a[i] = a[index];
                index++;
            }

            for(int i = 0; i < temp.Length; i++)
            {
                a[noOfEleToLeftShift] = temp[i];
                noOfEleToLeftShift++;
            }
            
            Console.WriteLine(string.Join(" ", temp));
            Console.WriteLine(string.Join(" ", a));

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}