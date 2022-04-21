using System;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {

        #region MySolution
        string sresult = "";
        for (int i = 0; i < n.ToString().Length; i++)
        {
            int tempResult = (int)char.GetNumericValue(n.ToString()[i]);
            sresult += tempResult * tempResult;

        }
        return int.Parse(sresult);
        #endregion

        #region Linq Version
        return int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));
        #endregion
    }

    public static void Main()
    {
        Console.WriteLine(SquareDigits(593123123));
    }
}