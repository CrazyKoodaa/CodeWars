using System;

namespace Bouncing_Ball
{
    public class BouncingBall
    {

        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || (bounce <= 0 || bounce >= 1) || window > h) return -1;
            Console.WriteLine($"{h} {bounce} {window}");
            int times = 1;
            Console.WriteLine(times);
            while (h > 1.5f)
            {
                h *= bounce;
                times+=2;
                Console.WriteLine(times);

            }
            // your code
            return (times -= 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"{BouncingBall.bouncingBall(3.0, 0.66, 1.5)} = 3");
            Console.WriteLine("-------------------");
            Console.WriteLine($"{BouncingBall.bouncingBall(30.0, 0.66, 1.5)} = 15");
        }
    }
}
