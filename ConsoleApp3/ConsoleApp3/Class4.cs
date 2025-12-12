using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    public class PersonA
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
    internal class Class4
    {
        public static void Main7()
        {
            int numberOfpeople = int.Parse(Console.ReadLine());
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < numberOfpeople; i++)
            {
                PersonA person= new PersonA();
                person.Name = Console.ReadLine();
                person.Age= int.Parse(Console.ReadLine());
                arrayList.Add(person);
            }

            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
