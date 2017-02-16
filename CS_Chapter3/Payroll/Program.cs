using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourPay;
            double hourWork;
            double grossPay; // = hourPay * hourWork;
            double withTax;
            double netPay;

            // USER PROMPT
            Console.Write("Enter your hourly pay: ");
            hourPay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the hours you worked");
            hourWork = Convert.ToDouble(Console.ReadLine());

            grossPay = hourPay * hourWork;

            // WITHHOLDING TAX
            if (grossPay <= 300)
                withTax = grossPay * 0.10;
            else
                withTax = grossPay * 0.12;

            netPay = grossPay - withTax;

            Console.WriteLine
        }
    }
}
