using System;

namespace Training_on_Maximum_subarray_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (Kata.MaxSequence(new int[0]) == 0)
                Console.WriteLine("test 1 okay");
            if (Kata.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }) == 6)
                Console.WriteLine("test 2 okay");

        }
    }

    public static class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            //TODO : create code
            if (arr.Length == 0)
                return 0;

            int sum = 0, max = 0; //pos1 = 0, pos2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = 0;
                for (int x = i; x < arr.Length; x++)
                {
                    sum += arr[x];
                    if (sum > max)
                    {
                        max = sum;
                        //pos1 = i;
                        //pos2 = x;
                    }
                }
            }

            Console.WriteLine($"Max = {max}");
            return max;
        }
    }
}
