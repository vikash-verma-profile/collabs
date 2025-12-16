using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
   public  class SampleProgram
    {
        static SampleProgram()
        {
            Console.WriteLine("I am called");
        }
        public static int Name;
        public static void Print()
        {
            Console.WriteLine(Name);
        }
    }
    public class SampleProgram1:SampleProgram
    {
        static int sum;
        public static void PrintS()
        {
            Console.WriteLine(sum + Name);
        }
    }
    internal class Class7
    {
        static Class7()
        {
            Console.WriteLine("I am called");
        }
        public static void Main9()
        {
            SampleProgram s = new SampleProgram();
            SampleProgram1 x = new SampleProgram1();
            
            SampleProgram.Name = 78;
            SampleProgram.Print();
        }
    }
}
