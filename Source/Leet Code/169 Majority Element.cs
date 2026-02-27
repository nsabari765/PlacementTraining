using System.Diagnostics;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 1, 1, 1, 2, 2, 3 };
        Console.WriteLine(MajorityElement(a));
    }

    public static int MajorityElement(int[] nums)
    {
        int size = nums.Length;
        Dictionary<int, int> counts = new();
        int max = 0;

        foreach (var num in nums)
        {
            if (!counts.ContainsKey(num))
            {
                counts[num] = 1;
            }
            else
            {
                counts[num]++;
            }
        }

        foreach (var key in counts.Keys)
        {
            if (counts[key] > size / 2)
            {
                max = key;
            }
        }

        Console.WriteLine(string.Join(",", counts));
        Console.WriteLine($"Max: {max}");

        return max;
    }
}