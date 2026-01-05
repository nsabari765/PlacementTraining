using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the no. of Rows");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the no. of Cols");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[rows, cols];
        int sum = 0;

        Console.WriteLine("Enter A's Inputs");

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write($"Enter [{i},{j}]: ");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
             }
        }

        Console.WriteLine("Original Matrix: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Transposed Matrix: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(a[j, i] + "\t");
            }

            Console.WriteLine();
        }

    }
}