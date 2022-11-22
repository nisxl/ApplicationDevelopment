using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week4
{
    class ProtInherit: ProtClass
    {
        public ProtInherit() { 
            ProtClass ob1 = new ProtClass();
            Console.WriteLine(ob1.protExample);

        }   
        //public override void protExample()
        //{
        //    Console.("this method has been overridden");
        //}




    }
}
