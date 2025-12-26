using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Vehicle InsertData()
        {
            Vehicle obj = new Vehicle();
            obj.Id =int.Parse(Console.ReadLine());
            obj.Name = Console.ReadLine();
            return obj;
        }
        public void PrintData(List<Vehicle> vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Id}-{item.Name}");
            }
        }
        public List<Vehicle> UpdateData(List<Vehicle> vehicles, Vehicle obj)
        {
            List<Vehicle> vehiclenew= new List<Vehicle>();
            //Vehicle objToBeRemoved = new Vehicle();
            foreach (var item in vehicles)
            {
                if (item.Id != obj.Id)
                {
                    vehiclenew.Add(item);
                }
            }
            vehiclenew.Add(obj);
            return vehiclenew;
        }
        public List<Vehicle> DeleteData(List<Vehicle> vehicles, int Id)
        {
            List<Vehicle> vehiclenew = new List<Vehicle>();
            foreach (var item in vehicles)
            {
                if (item.Id != Id)
                {
                    vehiclenew.Add(item);
                }
            }
            return vehiclenew;
        }
    }
    internal class Class7
    {
        public static void Main11()
        {
            List<Vehicle> vehicles= new List<Vehicle>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter a choice \n 1.Add \n 2.List \n 3.Update \n4. Delete \n 5.Exit");
                int choice = int.Parse(Console.ReadLine());
                Vehicle obj = new Vehicle();
                switch (choice)
                {
                    case 1:
                        vehicles.Add(obj.InsertData());
                        Console.WriteLine("Added Successfully");
                        break;
                    case 2:
                        obj.PrintData(vehicles);
                        break;
                    case 3:
                        int Id = int.Parse(Console.ReadLine());
                        string ValueToUpdate = (Console.ReadLine());
                        vehicles = obj.UpdateData(vehicles, new Vehicle { Id = Id, Name = ValueToUpdate });
                        Console.WriteLine("updated Successfully");
                        break;
                    case 4:
                        int IdToDelete = int.Parse(Console.ReadLine());
                        vehicles = obj.DeleteData(vehicles, IdToDelete);
                        Console.WriteLine("Deleted Successfully");
                        break;
                    case 5:
                        Console.WriteLine("Exiting");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
