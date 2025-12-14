using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class Class4
    {
        public static void Main()
        {
            Console.WriteLine("===========INPUT==========");
            Stack arrayList = new Stack();
            arrayList.Push(1);
            arrayList.Push("Vikash");
         
            Console.WriteLine("===========List==========");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===========REMOVE==========");
            arrayList.Pop();
            
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===========FIND==========");

            Console.WriteLine($"Found :  {arrayList.Contains(1)}");
            Console.WriteLine($"Count :  {arrayList.Count}");
            foreach (var item in arrayList)
            {
                  Console.WriteLine(item);
            }

            Console.WriteLine("===========UPDATE==========");

            //if()
            arrayList.Push(2);
            Console.WriteLine("Give the input to update");
            var inputValue = Console.ReadLine();
            Console.WriteLine("Give the Updated Value to update");
            var UpdatedValue = Console.ReadLine();
            if (arrayList.Contains(inputValue))
            {
                arrayList.(inputValue);
                arrayList.Add(UpdatedValue);
            }
            else
            {
                Console.WriteLine("Please enter correct value");
            }

            foreach (var item in arrayList)
            {

                if (item is Person2)
                {
                    Person2 Obj = (Person2)item;
                    Console.WriteLine($"{Obj.Id} : {Obj.Name}");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
    }
}
