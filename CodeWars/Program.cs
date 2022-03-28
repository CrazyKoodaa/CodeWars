using System;

namespace CodeWars
{
    internal class Program
    {
        public class Number
        {
            public int DigitalRoot(long n)
            {
                // Your awesome code here!
                long sumNumber = 0;
                if (n < 10) sumNumber = n;
                else
                {
                    while (true)
                    {
                        sumNumber = 0;
                        string temp = n.ToString();
                        for (int i = 0; i < temp.Length; i++)
                        {
                            sumNumber += (int)(temp[i]) - 48;
                        }
                        if (sumNumber >= 10) n = sumNumber;
                        else
                        {
                            return (int)sumNumber;

                        }

                    }

                }
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sumNumber = 0;
            if (number < 10) sumNumber = number;
            else
            {
                while (true)
                {
                    sumNumber = 0;
                    string temp = number.ToString();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        sumNumber += Convert.ToInt32(temp[i]) - 48;
                    }
                    if (sumNumber >= 10) number = sumNumber;
                    else
                    {
                        Console.WriteLine($"Sum is {sumNumber}");
                        return;
                    }

                }
            }


            
            Console.WriteLine($"Sum is {sumNumber}");
            
         }
    }
}
