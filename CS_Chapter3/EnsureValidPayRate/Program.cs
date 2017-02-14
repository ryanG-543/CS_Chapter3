using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            const double LOW = 5.65;
            const double HIGH = 49.99;
            string payString;
            int pay;
            int weekly;

            // Prompt the user for hourly pay
            Console.WriteLine("What is the hourly pay?");
            payString = Console.ReadLine();

            // Convert the input pay into a number
            pay = Convert.ToInt32(payString);
            weekly = pay * 40;

            // Check to see if the pay is within an appropriate range
            if (pay > LOW && pay < 49.99) 
                Console.WriteLine("You make ${0} an hour and ${1} a week", pay, weekly);
            else
                Console.WriteLine("TRY AGAIN");
                payString = Console.ReadLine();
                pay = Convert.ToInt32(payString);

            if (pay > LOW && pay < HIGH)
                Console.WriteLine("You make ${0} an hour and ${1} a week", pay, weekly);
            else
                Console.WriteLine("TRY AGAIN");
                payString = Console.ReadLine();
                pay = Convert.ToInt32(payString);

            if (pay > LOW && pay < HIGH)
                Console.WriteLine("You make ${0} an hour and ${1} a week", pay, weekly);
            else 
                Console.WriteLine("ERROR");
        }
    }
}
