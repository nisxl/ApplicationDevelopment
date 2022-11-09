using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class Prime
    {
        public static void PrimeOrNot(int num)
        {
            int cnt = 0;
            for (int i = 1; i <= num; i++)
            {
                
                if (num % i == 0)
                {
                    
                    cnt = cnt + 1;
                }
            }
            if (cnt > 2)
            {
                Console.WriteLine("Composite");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
