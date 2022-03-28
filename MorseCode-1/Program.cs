using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MorseCode_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //try
            {
                
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            //catch (Exception ex)
            //{
            //    Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            //}
        }
    }

    class MorseCodeDecoder
    {
        private static Dictionary<string, char> _morseAlphabetDictionary;
        public static string Decode(string morseCode)
        {
            _morseAlphabetDictionary = new Dictionary<string, char>()
                                   {
                                       {".-", 'a'},
                                       {"-...", 'b'},
                                       {"-.-.", 'c'},
                                       {"-..", 'd'},
                                       {".", 'e'},
                                       {"..-.", 'f'},
                                       {"--.", 'g'},
                                       {"....", 'h'},
                                       {"..", 'i'},
                                       {".---", 'j'},
                                       {"-.-", 'k'},
                                       {".-..", 'l'},
                                       {"--", 'm'},
                                       {"-.", 'n'},
                                       {"---", 'o'},
                                       {".--.", 'p'},
                                       {"--.-", 'q'},
                                       {".-.", 'r'},
                                       {"...", 's'},
                                       {"-", 't'},
                                       {"..-", 'u'},
                                       {"...-", 'v'},
                                       {".--", 'w'},
                                       {"-..-", 'x'},
                                       {"-.--", 'y'},
                                       {"--..", 'z'},
                                       {"-----", '0'},
                                       {".----", '1'},
                                       {"..---", '2'},
                                       {"...--", '3'},
                                       {"....-", '4'},
                                       {".....", '5'},
                                       {"-....", '6'},
                                       {"--...", '7'},
                                       {"---..", '8'},
                                       {"----.", '9'}
                                   };
            string[] splittingWords = morseCode.Split("  "); // now it's morse code ist splittet to splittingWords[0] = Hey and splittingWords[1] = Jude
            string final = "";
            char[] charsToTrim = { ' ' };
            

            for (int i = 0; i < splittingWords.Length; i++)
            {
                string[] word = splittingWords[i].Split(' ');  // now word is the single letters of Hey
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == "")
                        final += " ";
                    else
                        final += _morseAlphabetDictionary[word[j]];
                }

            }
            return final.ToUpper().Trim(charsToTrim);
            

            // throw new System.NotImplementedException("Please provide some code.");
        }
    }

}


// MorseCode.Get(".--")(returns string)
