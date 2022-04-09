using System;
using System.Net;

public class CountIPAddresses
{

    public static long IpsBetween(string start, string end)
    {

        #region MySolution
        /*
        var startNumber = start.Split('.');
        var endNumber = end.Split('.');

        long iStart = 0, iEnd = 0;

        for (double i = 0, z = 3; i < startNumber.Length; i++, z--)
        {   
            iStart += (long)(Convert.ToInt64(startNumber[(int)i]) * Math.Pow(256, z));
            iEnd += (long)(Convert.ToInt64(endNumber[(int)i]) * Math.Pow(256, z));
        }

        return iEnd - iStart;
        */
        #endregion

        #region BetterSolution
        

        return (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(end).Address) -
            (long)(uint)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(start).Address);

        #endregion


    }
}

namespace Count_IP_Addresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
            Console.WriteLine(CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
            Console.WriteLine(CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"));
        }
    }
}
