using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Person
    {
        //public Person()
        //{

        //}

        public int Id = 10;
        public Person(string Name)
        {
            Console.WriteLine("I am Person :"+ Name);
        }
    }
    class Student : Person
    {
        public int Id=20;
        public Student(string name,string StudentName):base(name)
        {
            Console.WriteLine("I am Student"+ StudentName);
           
        }
        public void Print()
        {
            Console.WriteLine(base.Id);
        }
    }
    internal class Class3
    {
        public static void Main5()
        {
            Student studentstudent = new Student("Vikash","Sharma");
            studentstudent.Print();
        }
    }
}
