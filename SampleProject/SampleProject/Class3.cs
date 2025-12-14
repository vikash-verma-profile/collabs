using System.Collections;

namespace SampleProject
{
    //non-generic 

    public class Person2
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
    internal class Class3
    {
        public static void Main6()
        {
            Console.WriteLine("===========INPUT==========");
            ArrayList arrayList= new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Vikash");
            arrayList.Add('c');
            arrayList.Add(9.090);
            Person2 person = new Person2();
            person.Id = 1;
            person.Name = "some ame";
            Person2 person2 = new Person2 { Id = 1, Name = "Vikash" };
            arrayList.Add(person2);
            arrayList.Add(new Person2 { Id = 2, Name = "Rakesh" });
            //var s = new { Id = 3, Name = "Sumit" };
            //arrayList.Add(s);
            //char[] sample= new char[3] {'a','b','c' };
            //string x = sample as string;
            //Console.WriteLine(x);

            Console.WriteLine("===========List==========");
            foreach (var item in arrayList)
            {
               
                if (item is Person2)
                {
                    Person2 Obj = (Person2)item;
                    Console.WriteLine($"{Obj.Id} : {Obj.Name}");
                    //Console.WriteLine(Obj);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("===========REMOVE==========");
            //arrayList.Remove(1);
            arrayList.Remove("Vikash");
            //arrayList.RemoveAt(1);
            arrayList.Remove(person2);
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

            Console.WriteLine("===========FIND==========");

            Console.WriteLine($"Found :  {arrayList.Contains(1)}");
            Console.WriteLine($"Count :  {arrayList.Count}");
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

            Console.WriteLine("===========UPDATE==========");

            //if()
            arrayList.Add(2);
            Console.WriteLine("Give the input to update");
            var inputValue = Console.ReadLine();
            Console.WriteLine("Give the Updated Value to update");
            var UpdatedValue =Console.ReadLine();
            if (arrayList.Contains(inputValue))
            {
                arrayList.Remove(inputValue);
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
