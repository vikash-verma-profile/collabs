using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //abtrsact class: instance cannot be created
    public abstract class Sample:ISample
    {
        public Sample()
        {
            Console.WriteLine("Hi I am Sample ");
        }
        public abstract void Print();

        public void Display()
        {
            Console.WriteLine("Display Method");
        }

        public void PrintI()
        {
            throw new NotImplementedException();
        }
    }

    abstract class CSample1
    {
        public abstract void Print();
    }
    interface ISample
    {
        void PrintI();
    }
    //selead class : Cannot be extended
    sealed class Sample1
    {

    }
    //concreate class
    public class Sample2 : Sample,ISample
    {
        public Sample2()
        {
            Console.WriteLine("Hi I am Sample 2 ");
        }
        public override void Print()
        {
            Console.WriteLine("Hello I am Print Method");
        }

        public void PrintI()
        {
            throw new NotImplementedException();
        }
    }
    internal class Class1
    {
        //abstarct class
        public static void Main4()
        {
            Sample sample= new Sample2();
            sample.Print();
        }
    }
}
