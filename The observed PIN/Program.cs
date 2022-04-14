using System;
using System.Collections.Generic;
using System.Linq;

namespace The_observed_PIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var output = Kata.GetPINs("46");
            foreach (var pin in output)
                Console.WriteLine(pin);
        }
    }
    public class Kata
    {
        public static List<string> GetPINs(string observed) =>
        new[] { "08", "124", "1235", "236", "1457", "24568", "3569", "478", "57890", "689" }[observed[0] - '0'].SelectMany(c => observed.Length > 1 ? GetPINs(observed.Substring(1)).Select(p => c + p) : new[] { "" + c }).ToList();
        
        
        
        
        /*
        {
            
            Console.WriteLine($"That's the start {observed} number");
            char pinDigit;
            List<char>[] vs = new List<char>[observed.Length];

            for (int i = 0; i < observed.Length; i++)
            {
                vs[i] = new List<char>();
                //foreach (var pin in observed)
                pinDigit = observed[i];
               
                switch (pinDigit)
                {
                    case '1':
                        vs[i].Add('1');
                        vs[i].Add('2');
                        vs[i].Add('4');
                        break;
                    case '2':
                        vs[i].Add('1');
                        vs[i].Add('2');
                        vs[i].Add('3');
                        vs[i].Add('5');
                        break;
                    case '3':
                        vs[i].Add('2');
                        vs[i].Add('3');
                        vs[i].Add('6');
                        break;
                    case '4':
                        vs[i].Add('1');
                        vs[i].Add('4');
                        vs[i].Add('5');
                        vs[i].Add('7');
                        break;
                    case '5':
                        vs[i].Add('2');
                        vs[i].Add('4');
                        vs[i].Add('5');
                        vs[i].Add('6');
                        vs[i].Add('8');
                        break;
                    case '6':
                        vs[i].Add('3');
                        vs[i].Add('5');
                        vs[i].Add('6');
                        vs[i].Add('9');
                        break;
                    case '7':
                        vs[i].Add('4');
                        vs[i].Add('7');
                        vs[i].Add('8');
                        break;
                    case '8':
                        vs[i].Add('0');
                        vs[i].Add('5');
                        vs[i].Add('7');
                        vs[i].Add('8');
                        vs[i].Add('9');
                        break;
                    case '9':
                        vs[i].Add('6');
                        vs[i].Add('8');
                        vs[i].Add('9');
                        break;
                    case '0':
                        vs[i].Add('0');
                        vs[i].Add('8');
                        break;
                };
            }

            List<string> result = new List<string>();


            int depthOfVS = vs.Count();


            for (int n1 = 0; n1 < vs[0].Count; n1++)
            {
                if (depthOfVS >= 2)
                    for (int n2 = 0; n2 < vs[1].Count; n2++)
                        if (depthOfVS >= 3)
                            for (int n3 = 0; n3 < vs[2].Count; n3++)
                                if (depthOfVS >= 4)
                                    for (int n4 = 0; n4 < vs[3].Count; n4++)
                                        if (depthOfVS >= 5)
                                            for (int n5 = 0; n5 < vs[4].Count; n5++)
                                                if (depthOfVS >= 6)
                                                    for (int n6 = 0; n6 < vs[5].Count; n6++)
                                                        if (depthOfVS >= 6)
                                                            for (int n7 = 0; n7 < vs[6].Count; n7++)
                                                                if (depthOfVS >= 7)
                                                                    for (int n8 = 0; n8 < vs[7].Count; n8++)
                                                                        result.Add(vs[0][n1].ToString() + vs[1][n2] + vs[2][n3] + vs[3][n4] + vs[4][n5] + vs[5][n6] + vs[6][n7] + vs[7][n8]);
                                                                else result.Add(vs[0][n1].ToString() + vs[1][n2] + vs[2][n3] + vs[3][n4] + vs[4][n5] + vs[5][n6] + vs[6][n7]);
                                                        else result.Add(vs[0][n1].ToString() + vs[1][n2] + vs[2][n3] + vs[3][n4] + vs[4][n5] + vs[5][n6]);
                                                else result.Add(vs[0][n1].ToString() + vs[1][n2] + vs[2][n3] + vs[3][n4] + vs[4][n5]);
                                        else result.Add(vs[0][n1].ToString() + vs[1][n2] + vs[2][n3] + vs[3][n4]);
                                else result.Add(vs[0][n1].ToString() + vs[1][n2] + vs[2][n3]);
                        else result.Add(vs[0][n1].ToString() + vs[1][n2]);   
                else result.Add(vs[0][n1].ToString());
            }

            result.Sort();
            foreach (var item in result)
                Console.WriteLine(item);
            return result;
            
        }*/
    }
}


