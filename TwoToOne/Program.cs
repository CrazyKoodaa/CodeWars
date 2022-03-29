using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Longest("aretheyhere", "yestheyarehere"));
            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
        }

        public static string Longest(string s1, string s2)
        {
            string solution = "";
            List<char> twoToOne = new List<char>();

            foreach (char c in s1)
                twoToOne.Add(c);
            foreach (char c in s2)
                twoToOne.Add(c);

            var noDupes = twoToOne.Distinct().ToList();
            noDupes.Sort();
            foreach (char c in noDupes)
                solution += c;
            return solution;



        }
    }
}
