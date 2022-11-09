using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class Swap
    {
        public static void SwapNumbers(int num1, int num2){
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"The swapped numbers are {num1} {num2}");

        }

    }
}
