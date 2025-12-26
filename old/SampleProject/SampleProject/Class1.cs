using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class Person
    {
        protected int Age;
        public void Greet()
        {
            Console.WriteLine("hello");
        }
        public void SetAge(int Age)
        {
            this.Age = Age;
        }
    }
    public class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {Age} years");
        }
    }
    public class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    internal class Class1
    {
        public static void Main3()
        {
            Person person=new Person();
            person.Greet();
            Student student=new Student();
            student.SetAge(1);
            student.Greet();
            student.ShowAge();
            Teacher teacher = new Teacher();
            teacher.SetAge(43);
            teacher.Greet();
            teacher.Explain();

        }
    }
}
