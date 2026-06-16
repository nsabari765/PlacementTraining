public class HelloWorld
{
    public static void Main(string[] args)
    {
        string s = "sabari";

        Console.WriteLine("Last Word Count = " + LengthOfLastWord(s));
    }

    public static int LengthOfLastWord(string s)
    {
        int size = s.Length;
        int lastWordCount = 0;

        for (int i = size - 1; i >= 0; i--)
        {
            if (s[i] == ' '
                && i != size - 1
                && s[i + 1] != ' ')
            {
                break;
            }

            if (s[i] != ' ')
            {
                lastWordCount++;
            }
        }

        return lastWordCount;
    }
}