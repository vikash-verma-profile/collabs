using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Machicnic
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
    internal class Class10
    {
        public static void Main12()
        {
            Dictionary<string,Machicnic> MachicnicList= new Dictionary<string, Machicnic>();
            MachicnicList.Add("E101", new Machicnic { EmpId = "E101", Age = 40, Name = "Ram", Salary = 3000 });
            Machicnic m = new Machicnic();
            m.EmpId = "E104";
            m.Age = 50;
            m.Salary = 40000;
            m.Name = "Shyam";
            Machicnic m1 = new Machicnic();
            m1.EmpId = Console.ReadLine();
            m1.Age = int.Parse(Console.ReadLine());
            m1.Salary = double.Parse(Console.ReadLine());
            m1.Name = Console.ReadLine();
            MachicnicList.Add("E104", m);
            MachicnicList.Add(m1.EmpId, m1);

            foreach (var item in MachicnicList)
            {
                Console.WriteLine($"{item.Key} | {item.Value.Name} | {item.Value.Age}");
            }
            foreach (var item in MachicnicList.Values)
            {
                Console.WriteLine($"{item.EmpId} | {item.Name} | {item.Age}");
            }

            //Dictionary<int,string> dist= new Dictionary<int,string>();
            //dist.Add(1,"Vikash");
            //dist.Add(2, "Vikash 1");
            //dist.Add(3, "Vikash 2");
            //foreach (var item in dist)
            //{
            //    Console.WriteLine($"{item.Key}-{item.Value}");
            //}
            //if(dist.ContainsKey(2))
            //{
            //    dist[2] = "Rakesh";
            //}
            //Console.WriteLine("=======after update=======");
            //foreach (var item in dist)
            //{
            //    Console.WriteLine($"{item.Key}-{item.Value}");
            //}
            //dist.Remove(3);
            //Console.WriteLine("=======after update=======");
            //foreach (var item in dist)
            //{
            //    Console.WriteLine($"{item.Key}-{item.Value}");
            //}
        }
    }
}
