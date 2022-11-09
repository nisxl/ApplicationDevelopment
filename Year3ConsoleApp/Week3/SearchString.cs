using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class SearchString
    {
        public static void SearchInArray(string num)
        {
            int a = 0;
            var fibNumbers = new List<string> { "nischal", "bidhan", "diskhyant" };
            foreach (string element in fibNumbers)
            {
                if (num.Equals(element))
                {
                    Console.WriteLine($"{num} found\n");
                    a = 1;
                    break;
                }



            }
            if (a != 1)
            {
                Console.WriteLine("not found");
            }

        }
    }
}
