// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var start = 1000;
		var end = 9999;
		var mod = 0;
		
		for(int i = start; i <= end; i++)
		{
			var isPrime = IsPrime(i);
			
			if(isPrime)
			{
				mod = i % 10;
				
				while(mod > 0)
				{
					
					mod = mod / 10;
				}
			}
		}
    }
    
	private static bool IsDigitPrime(int number)
	{
		if(number == 2 || number == 3 || number == 5 || number == 7)
		{
			return true;
		}
		
		return false;
	}
	
    private static bool IsPrime(int number)
    {
        try
        {
            int count = 0;
            
            for(int i = 1; i <= number; i++)
            {
                if((number % i) == 0)
                {
                    count++;
                }
            }
            
            if(count == 2)
            {
                return true;
            }
            
            return false;
        }
        catch(Exception ex)
        {
            throw;
        }
    }
}