using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class Person1
    {
        public string Name { get; set; }
        public Person1(string Name)
        {
            this.Name = Name;
        }
    }
    public class Student1 : Person1
    {
        public Student1(string Name) : base(Name)
        {

        }
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
    }
    public class Teacher1 : Person1
    {
        public Teacher1(string Name) : base(Name)
        {

        }
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    internal class Class2
    {
        public static void Main4()
        {
            Person1[] perons = new Person1[3];
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    string Name = Console.ReadLine();
                    Teacher1 obj = new Teacher1(Name);
                    perons[i] = obj;
                }
                else
                {
                    string Name = Console.ReadLine();
                    Student1 obj = new Student1(Name);
                    perons[i] = obj;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Teacher1 s = (Teacher1)(perons[i]);
                    s.Explain();
                }
                else
                {
                    Student1 s = (Student1)(perons[i]);
                    s.Study();
                }
            }
        }
    }
}
