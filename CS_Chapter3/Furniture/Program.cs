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
            int p = 100;
            int o = 225;
            int m = 310;
            char wood;
            string woodString;

            // PROPMPT USER FOR WOOD TYPE
            Console.WriteLine("What kind of wood do you want?");
            woodString = Console.ReadLine().ToLower();
            wood = Convert.ToChar(woodString);

            //SWITCH STATEMENT
            switch(wood)
            { 
                case 'p':
                    Console.WriteLine("The cost of a pine table is ${0}", p);
                        break;
                case 'o':
                    Console.WriteLine("The cost of an oak table is ${0}", o);
                        break;
                case 'm':
                    Console.WriteLine("The cost of a mahogany table is ${0}", m);
                        break;
                default:
                    Console.WriteLine("Your cost is $0");
                        break;
            }
        }
    }
}
