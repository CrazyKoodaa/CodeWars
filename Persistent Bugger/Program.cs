using System;

public class Persist
{
    public static int Persistence(long n)
    {
        Console.WriteLine($"--- Income {n}");
        int tempResult = (int)n;

        if (n >= 0 && n < 9) return 0;

        int howManyTimes = 0;

        while (tempResult > 9)
        {
            howManyTimes++;
            string s = tempResult.ToString();
            tempResult = 1;
            for (int j = 0; j < s.Length; j++)
            {
                tempResult *= Convert.ToInt32(s[j] - 48);
            }
            Console.WriteLine($"tempresult = {tempResult}");
        }
        
        return howManyTimes;

    }

    public static void Main()
    {
        Console.WriteLine("Solution: " + Persistence(39) + " = 3?\n");
        Console.WriteLine("Solution: " + Persistence(4) + " = 0?\n");
        Console.WriteLine("Solution: " + Persistence(25) + " = 2?\n");
        Console.WriteLine("Solution: " + Persistence(999) + " = 4?\n");
    }
}
