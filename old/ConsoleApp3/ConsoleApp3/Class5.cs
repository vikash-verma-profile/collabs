using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Doctor
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }
    }
    internal class Class5
    {
        public static void Main8()
        {
            Doctor d=new Doctor();
            d.Name = "Vikash";
            Console.WriteLine(d.Name);
        }
    }
}
