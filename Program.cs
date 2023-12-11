using System;
using System.Data;

namespace SystemTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            System.Console.WriteLine("DateTime Now is: " + localDate);
        }
    }
}