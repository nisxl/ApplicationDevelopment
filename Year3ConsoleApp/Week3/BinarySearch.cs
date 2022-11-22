using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class BinarySearch
    {
        public static void BinarySearching(int num)
        {
            int a = 0;
            var fibNumbers = new List<int> { 0, 1, 5, 8, 9, 12 };
            int lenthh = fibNumbers.Count;
            Boolean found = false;
            int low = 0;
            int high = lenthh - 1;
            int mid = lenthh / 2;


            while (!found)
            {

                if (low > high)
                {
                    Console.WriteLine("hawa");
                    break;
                }
                else
                {
                    if (num == fibNumbers[mid])
                    {
                        found = true;
                        break;
                    }
                    else if (num > mid)
                    {
                        low = mid + 1;
                        mid = (high + low) / 2;
                    }
                    else
                    {
                        high = mid - 1;
                        mid = (high + low) / 2;
                    }
                }
                
            }
            if(found)
            {
                Console.WriteLine("foundddd");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            
        }
    }
}
