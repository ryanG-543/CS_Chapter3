using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class IfElseDecision
    {
        static void Main(string[] args)
        {
            const double HIGH = 5.65;
            string payString;
            int pay;
            Console.WriteLine("What is the hourly pay?");
            payString = Console.ReadLine();
            pay = Convert.ToInt32(payString);
            if (pay > HIGH)
                Console.WriteLine("Excellent");
            else
                Console.WriteLine("ERROR. PAY MUST BE GREATER THAN ${0}", HIGH);
        }
    }
}
