using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class SearchArray
    {
        public static void SearchInArray(int num)
        {
            int a = 0;
            var fibNumbers = new List<int> { 0,1,5,8,9,12 };
            foreach (int element in fibNumbers)
            {
                if (num == element)
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
