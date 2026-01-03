using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the no. of Rows");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the no. of Cols");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[rows,cols];
        int[,] b = new int[rows, cols];
        int[,] result = new int[rows,cols];

        Console.WriteLine("Enter A's Inputs");

        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Enter a of {i}{j}: ");
                a[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter B's Inputs");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Enter b of {i}{j}: ");
                b[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("A's Array");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine("\n");
        }

        Console.WriteLine("B's Array");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(b[i, j] + "\t");
            }

            Console.WriteLine("\n");
        }

        for (int i = 0; i < rows; i++)
        {
            int total = 0;

            for (int j = 0; j < cols; j++)
            {
                total += a[i, j] * b[j, i];
                result[i,j] = total;
            }
        }

        Console.WriteLine("A X B = ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + "\t");
            }

            Console.WriteLine("\n");
        }
    }
}