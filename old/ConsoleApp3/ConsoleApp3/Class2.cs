using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class2
    {
        // unboxing vs boxing
        public static void Main2()
        {
            object a=new object();
            int x = 4;
            a = x;// boxing
            x = (int)a;// un-boxing
            Console.WriteLine($"object Value{a}");
            Console.WriteLine($"Varaible Value{x}");
        }
    }
}
