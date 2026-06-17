using PlacementTraining2;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Number();
        Console.WriteLine("Program runs successfully");
    }

    public static void Number()
    {
        RandomizedSet randomizedSet = new RandomizedSet();
        int userChoice = 0;

        do
        {
            Console.WriteLine("1. Insert\n2. Remove\n3. Get Random Element");
            Console.Write("Enter your choice: ");
            int userDecision = Convert.ToInt32(Console.ReadLine());
            int number = 0;

            switch (userDecision)
            {
                case 1:
                    Console.Write("Enter a number: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    randomizedSet.Insert(number);
                    break;

                case 2:
                    Console.Write("Enter a number: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    randomizedSet.Remove(number);
                    break;

                case 3:
                    int num = randomizedSet.GetRandom();
                    Console.WriteLine("Random Number = " + num);
                    break;
            }

            Console.WriteLine("Do you wants to continue if yes type 1 else 0");
            userChoice = Convert.ToInt32(Console.ReadLine());
        } while (userChoice == 1);
    }
}