﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            const double LOW = 5.65;
            const double HIGH = 49.99;
            string payString;
            int pay;
            Console.WriteLine("What is the hourly pay?");
            payString = Console.ReadLine();
            pay = Convert.ToInt32(payString);
            if (pay < LOW) ;
                if (pay > HIGH)
                Console.WriteLine("ERROR");
            else
                Console.WriteLine("EXCELLENT");
        }
    }
}
