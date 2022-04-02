using System;
using System.Numerics;

namespace Solution
{
    public static class Kata
    {
        public static int Divide4(string a, string b)
        {
            return (int)BigInteger.ModPow(BigInteger.Parse(a), BigInteger.Parse(b), 4);
            
            /*
            // your code ..
            if (a == null || b == null || a.Length == 0 || b.Length == 0) return 0;
            try
            {
                if (Convert.ToInt32(b) == 0) return 1;
            }
            catch
            {
                Console.WriteLine("catched");
            }

            int numberToModulo = 4;
            var v1 = BigInteger.Parse(a);
            var v2 = BigInteger.Parse(b);

            var vResult = BigInteger.ModPow(v1, v2, numberToModulo);
            return (int)vResult;
            /*
            for (var i = 0; i < v2 - 1; i++)
            {
                vResult *= v1;
            }
            vResult %= numberToModulo;

            int result = (int)(vResult);
            return (int)result;*/
        }
        public static void Main()
        {
            //Console.WriteLine(Divide4("83758542733958800586962745393", "9594717985011091521596432109021598470117216367517301770215150885342361140437916569172071") + "= 1");
            Console.WriteLine(Divide4("2", "3") + "= 0");


        }
    }
}
