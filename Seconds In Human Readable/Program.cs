using System;

namespace Seconds_In_Human_Readable
{  
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(TimeFormat.GetReadableTime(359999));
        }
    }

    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            TimeSpan ts = TimeSpan.FromSeconds(seconds);

            return String.Format($"{(int)ts.TotalHours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}");
        } 
    }

}
