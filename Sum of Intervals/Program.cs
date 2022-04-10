using System;
using Interval = System.ValueTuple<int, int>;
using System.Collections.Generic;

namespace Sum_of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            #region MySolution
            /*
            Tuple<int,int>[] riding = new[] { new Tuple<int,int>(1, 2), new Tuple<int,int>(2, 6), new Tuple<int, int>(6, 55) };
            Dictionary<int,int> counts = new Dictionary<int,int>();
            
            foreach (var i in riding)
                for (int j = i.Item1; j < i.Item2; j++)
                    counts.TryAdd(j, i.Item2);

            Console.WriteLine(counts.Count);
            */
            #endregion

            #region LinqVersion
            return intervals
              .SelectMany(i => Enumerable.Range(i.Item1, i.Item2 - i.Item1))
              .Distinct()
              .Count();
            #endregion

        }
    }

}
