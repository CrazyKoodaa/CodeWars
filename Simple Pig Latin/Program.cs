using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static string PigIt(string str)
    {
        return string.Join(" ", str.Split(" ").Select(w => char.IsPunctuation(w[0]) ? w : $"{w[1..]}{w[0]}ay"));
        /*
        string[] sentence = str.Split(' ').ToArray();

        string result = "";

        foreach (string s in sentence)
        {
            if (s.Length > 1)
            {
                string firstChar = new string(s.Take(1).ToArray());
                string restWord = new string(s.TakeLast(s.Length - 1).ToArray());
                string ending = "ay";
                result += $"{restWord}{firstChar}{ending} ";

            }
            else
                result += s + " ";
        }


        return result.TrimEnd();*/
    }

    public static void Main()
    {
        Console.WriteLine(PigIt("Test Mach ! nada"));
    }
}