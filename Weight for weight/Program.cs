using System;
using System.Linq;
using System.Collections.Generic;

namespace Weight_for_weight
{
    public class WeightSort
    {

        public static string orderWeight(string strng)
        {
            // your code
            string result = "";
            Console.WriteLine(strng);
            int counting = 0;
            var inputs = strng.TrimEnd().TrimStart().Split(' ');
            int[,] pairs = new int[inputs.Length, 2];
            foreach (var input in inputs)
            {
                pairs[counting, 1] = Convert.ToInt32(input);
                foreach (var c in input)
                {
                    pairs[counting, 0] =
                        (from zif in input select int.Parse(zif.ToString())).Sum();

                }
                counting++;
            }


            int[,] temp = new int[1,2];

            for (int i = 1; i < pairs.GetLength(0); i++)
            {
                int j = i;
                int done = 0;

                for (j = i; j > 0; j--)                 // zahlen:  5 1 3
                {
                    if (pairs[j, 0] < pairs[j - 1, 0])        // wenn 1 < 5
                    {
                        temp[0, 0] = pairs[j, 0];            // speichere 1 in temp
                        temp[0, 1] = pairs[j, 1];

                        pairs[j, 0] = pairs[j - 1, 0];      // speichere 5 auf 2. stelle
                        pairs[j, 1] = pairs[j - 1, 1];
                        // speichere 1 auf 1. stelle
                        pairs[j - 1, 0] = temp[0, 0];
                        pairs[j - 1, 1] = temp[0, 1];
                        done = j - 1;
                    }
                    else
                        j = 0;
                }
                for (j = done; j > 0; j--)
                {
                    if (pairs[j, 1].ToString()[0] < pairs[j - 1, 1].ToString()[0] && pairs[j, 0] == pairs[j - 1, 0])
                    {
                        temp[0, 0] = pairs[j, 0];            // speichere 1 in temp
                        temp[0, 1] = pairs[j, 1];

                        pairs[j, 0] = pairs[j - 1, 0];      // speichere 5 auf 2. stelle
                        pairs[j, 1] = pairs[j - 1, 1];
                        // speichere 1 auf 1. stelle
                        pairs[j - 1, 0] = temp[0, 0];
                        pairs[j - 1, 1] = temp[0, 1];
                    }
                    else
                        j = 0;
                }
            }

            for (int k = 0; k < pairs.GetLength(0); k++)
                result += pairs[k, 1].ToString() + " ";

            return result.TrimEnd();

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var order = WeightSort.orderWeight("103 123 4444 99 2000");
            var order = WeightSort.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123");
            Console.WriteLine(order);
        }
    }
}
