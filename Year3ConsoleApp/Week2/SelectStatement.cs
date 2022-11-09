using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week2
{
    public class selectStatement
    {

        public static void SwitchCase()
        {
            Console.WriteLine("Press 1 for Apple");
            Console.WriteLine("Press 2 for Orange");

            var a = Console.ReadLine(); //get input from user

            switch (a)
            {
                case "1":
                    Console.WriteLine("Apple");
                    break;

                case "2":
                    Console.WriteLine("Orange");
                    break;

                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}