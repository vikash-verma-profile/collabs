using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PersonP
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class PersonHandler
    {
        public static List<PersonP> PersonList = new List<PersonP>();

        public static void AddPerson(PersonP person)
        { 
            PersonList.Add(person);
            Console.WriteLine("Person added successfully");

        }
        public static void Display()
        {
            if (PersonList.Count == 0)
            {
                Console.WriteLine("No person data .");
                return;
            }
            foreach (var item in PersonList)
            {
                Console.WriteLine(item.ID + " | " + item.Name);
            }
        }
        public static void UpdatePersons(int id,string NewName)
        {
            PersonP person = null;
            foreach (var item in PersonList)
            {
                if (item.ID == id)
                {
                    person = item;
                    break;
                }
            }
            PersonList.Remove(person);
            PersonP newPerson = new PersonP();
            newPerson.ID= id;
            newPerson.Name = NewName;
            PersonList.Add(newPerson);
            Console.WriteLine("Person record is updated .");
        }

        public static void DeletePerson(int id)
        {
            PersonP person = null;
            foreach (var item in PersonList)
            {
                if(item.ID==id)
                {
                    person=item;
                    break;
                }
            }
            PersonList.Remove(person);
            Console.WriteLine("Person deleted successfully.");
        }
      
    }
    internal class Class4
    {
        public static void Main()
        {
            // PersonHandler ph = new PersonHandler();
            //PersonP p = new PersonP();
            //p.ID = int.Parse(Console.ReadLine());
            //p.Name = Console.ReadLine();
            //ph.PersonList.Add(p);
            //PersonHandler.AddPerson(p);
            //PersonHandler.Display();
            //foreach (var item in ph.PersonList)
            //{
            //    Console.WriteLine(item.ID+"|"+item.Name);
            //}
            int ch = 0;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a Person");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Update");
                Console.WriteLine("5. Exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Please enter person details:");
                        PersonP p = new PersonP();
                        p.ID = int.Parse(Console.ReadLine());
                        p.Name = Console.ReadLine();
                        PersonHandler.AddPerson(p);
                        break;
                    case 2:
                        PersonHandler.Display();
                        break;
                    case 3:
                        Console.WriteLine("Please enter person ID:");
                        int ID = int.Parse(Console.ReadLine());
                        PersonHandler.DeletePerson(ID);
                        break;
                    case 4:
                        Console.WriteLine("Please enter person ID:");
                        int IDU = int.Parse(Console.ReadLine());
                        string Name = Console.ReadLine();
                        PersonHandler.UpdatePersons(IDU, Name);
                        break;
                    case 5:
                        Console.WriteLine("Exiting the application...");
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid choide.");
                        break;
                }
            } while (ch > 0);
            

        }
    }
}
