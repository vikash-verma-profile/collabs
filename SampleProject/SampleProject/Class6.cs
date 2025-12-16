using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{

    public class BaseClass
    {
        public string Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("Base class Print Method");
        }
        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
    public class DerivedClass:BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("Derived class Print Method");
        }
    }
    internal class Class6
    {
        public static void Main14()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Print();
            DerivedClass c=new DerivedClass();
            c.Print();

            BaseClass baseClass1= new DerivedClass(); 
            baseClass1.Print();

            baseClass.Name = "Vikash";
            Console.WriteLine(baseClass.ToString());


        }
    }
}
