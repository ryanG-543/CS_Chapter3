using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            char p = 100;
            char o = 225;
            char m = 310;
            char wood;
            string woodString;

            // PROPMPT USER FOR WOOD TYPE
            Console.WriteLine("What kind of wood do you want?");
            woodString = Console.ReadLine();
            wood = Convert.ToChar(woodString);

            // PINE
            if (wood == p)
                Console.WriteLine("The cost of a pine table is ${0}", p);

            // OAK
            if (wood == o)
                Console.WriteLine("The cost of an oak table is ${0}", o);

            // MAHOGANY
            if (wood == m)
                Console.WriteLine("The cost of a mahogany table is ${0}", m);

            // NONE
            if (wood != m || wood != o || wood != p)
                Console.WriteLine("Your cost is $0");

        }
    }
}
