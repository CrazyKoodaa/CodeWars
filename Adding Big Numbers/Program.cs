using System;
using System.Numerics;
using System.Collections.Generic;

public class Kata
{
    public static string Add(string a, string b)
    {
        // Fix this!
        return (BigInteger.Add(BigInteger.Parse(a), BigInteger.Parse(b))).ToString();

    }

    public static void Main()
    {
        Console.WriteLine(Add("555", "555"));
    }
} 