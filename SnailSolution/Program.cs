using System;

namespace SnailSolution
{
    internal class Program

    {
        public class SnailSolution
        {
            public static int[] Snail(int[][] array)
            {
                // enjoy
                int x, y;
                int[] result = new int[array.Length];

                x = array[0].Length;
                y = array[1].Length;
                Console.WriteLine(x + " " + y);

                return result;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        }
    }
}
