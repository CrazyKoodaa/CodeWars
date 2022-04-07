using System;
using System.Collections.Generic;
using System.Linq;

namespace Catching_Car_Mileage_Numbers
{
    /*
    #region MySolution
    public static class Kata
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            // Happy Coding :)
            //for (int i = 100; i <= 1000000000; i = i * 10)
            //    awesomePhrases.Add(i);

            if (number < 98) return 0;

            for (int i = 0; i < 3; i++)
            {
                // change the number to an List of Strings
                var listNumber = (number + i).ToString().ToList();

                //Aggregate(func: (result, item) => result + item);

                // check if the number is one of the 10^n s 
                // check later if result is 0 ? perfect : it'a not
                var is10th = listNumber.Skip(1).Aggregate(0, (a, b) => a + (b - '0'));


                // check if the digits are all the same in the number
                // check later if result is 'N' ? Not same : it's same
                var anyDigitIsSame = listNumber.Aggregate((last, curr) =>
                {
                    if (last == curr)
                    {
                        // Console.WriteLine($"Is not same {last} and {curr}");
                        return curr;
                    }
                    else return 'N';
                });

                // check for ascending
                // if result is 'N' ? Not in order : in order
                var numberAscending = listNumber.Aggregate((last, curr) =>
                {
                    if (last == '9')
                        last = '/';
                    
                    if (last + 1 == curr)
                    {
                        Console.WriteLine($"last {last} is smaller than curr {curr}");
                        return curr;
                    }
                    return 'N';
                });

                // check for descending
                // if result is 'N' ? Not in order : in order (don't forget to check the 2 miles b4
                var numberDescending = listNumber.Aggregate((last, curr) =>
                {
                    //if (last == '0')
                    //    last = ':';
                    if (last - 1 == curr)
                    {
                        //Console.WriteLine($"last {last} is smaller than curr {curr}");
                        return curr;
                    }
                    return 'N';
                });

                // result = false ? it's not a palindrom : check for the - 2 miles
                var result = Enumerable
                    .SequenceEqual((number+i).ToString().ToCharArray(), (number+i).ToString().ToCharArray().Reverse());

                foreach (var item in awesomePhrases)
                {
                    var temp = item - i;
                    if (temp == number && i == 0) return 2;
                    else if (temp == number && i > 0) return 1;
                        
                };
                    

                if ((result == true && i == 0 && number >= 100) || 
                    (numberDescending != 'N' && i == 0 && number >= 100) || 
                    (numberAscending != 'N' && i == 0 && number >= 100 ) || 
                    (anyDigitIsSame != 'N' && i == 0 && number >= 100) ||
                    (is10th == 0 && i == 0 && number >= 100))
                {
                    return 2;
                } 
                else if ((result == true && i >= 0) ||
                    (numberDescending != 'N' && i >= 0) ||
                    (numberAscending != 'N' && i >= 0) ||
                    (anyDigitIsSame != 'N' && i >= 0) ||
                    (is10th == 0 && i >= 0))
                {
                    return 1;
                } 
                
            }

            return 0;

        }
    }
    #endregion

    */
    #region SolutionWhatIWanted
    public static class Kata
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            return Enumerable.Range(number, 3)
              .Where(x => Interesting(x, awesomePhrases))
              .Select(x => (number - x + 4) / 2)
              .FirstOrDefault();
        }

        private static bool Interesting(int num, List<int> awesome)
        {
            if (num < 100) return false;
            var s = num.ToString();
            return awesome.Contains(num)
              || s.Skip(1).All(c => c == '0')
              || s.Skip(1).All(c => c == s[0])
              || "1234567890".Contains(s)
              || "9876543210".Contains(s)
              || s.SequenceEqual(s.Reverse());
        }
    }
    #endregion
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.IsInteresting(109, new List<int>() { 1337, 256 }));
            
            /*
             * Console.WriteLine(Kata.IsInteresting(98, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(99, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(100, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(1000000, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(1457, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(254, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(255, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(256, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(14541, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(145541, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(111111, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(55553, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(55554, new List<int>() { 1337, 256 }));
            Console.WriteLine(Kata.IsInteresting(55555, new List<int>() { 1337, 256 }));
            */

        }
    }
}
