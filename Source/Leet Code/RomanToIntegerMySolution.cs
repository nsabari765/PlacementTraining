public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] citations = { 1, 3, 1, 3, 4 };
        var userDecision = string.Empty;

        do
        {
            Console.WriteLine("Enter a Roman Number to Convert into Numerical Number: ");
            string roman = Console.ReadLine() ?? string.Empty;

            Console.WriteLine($"Numerical Number: {RomanToInt(roman)}");

            Console.WriteLine("Do you want to continue Y/N");
            userDecision = Console.ReadLine().ToUpper();
        } while (userDecision == "Y");
    }

    public static int RomanToInt(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        s = s.ToUpper();
        int sum = 0;

        Dictionary<Char, int> roman = new Dictionary<Char, int>
        {
            { 'I', 1},
            { 'V', 5},
            { 'X', 10},
            { 'L', 50},
            { 'C', 100},
            { 'D', 500},
            { 'M', 1000}
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (i == 0)
            {
                sum = roman[s[i]];
            }
            else if (roman[s[i - 1]] >= roman[s[i]])
            {
                sum += roman[s[i]];
            }
            else
            {
                int actual = roman[s[i]] - roman[s[i - 1]];
                sum = sum - roman[s[i - 1]];
                sum = actual + sum;
            }
        }

        return sum;
    }
}