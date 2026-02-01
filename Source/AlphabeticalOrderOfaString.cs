using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();
        string userDecision = string.Empty;

        do
        {
            char temp;
            Console.Write("Enter a string: ");
            string a = Console.ReadLine();
            int size = a.Length;
            char[] c = new char[size];
            int iSmall, jSmall;

            for(int i = 0; i < size; i++)
            {
                c[i] = a[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    iSmall = (c[i] >= 65 && c[i] <= 91) ? c[i] + 32 : c[i];
                    jSmall = (c[j] >= 65 && c[j] <= 91) ? c[j] + 32 : c[j];

                    if (iSmall > jSmall)
                    {
                        temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join("", c));

            Console.Write("Do you want to continue (y/n): ");
            userDecision = Console.ReadLine().ToLower();

        } while (userDecision == "y" || userDecision == "yes");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds / 60} s");
    }
}