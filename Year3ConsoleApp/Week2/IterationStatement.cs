using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week2
{
    public class IterationStatement
    {
        public static void WhileStatement(int num1)
        {
            while (num1 < 10)
            {
                Console.WriteLine(num1);
                num1++;
            }
        }

        public static void DoWhileStatement(int num1)
        {
            do
            {
                Console.WriteLine(num1);
                num1++; //it will add 1 ☻in num1 value
            }
            while (num1 < 10);
        }

        public static void ForLoop(int num1)
        {
            for (int i = num1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ForEachLoop()
        {
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers)
            {
                Console.Write($"{element} \n");
            }
        }
    
    }
}
