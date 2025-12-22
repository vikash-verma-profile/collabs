using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SimplePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Class3
    {
        public static void Main()
        {
            /*
            List<int> list= new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            Console.WriteLine(list.Where(x => x == 20).FirstOrDefault());
           // Console.WriteLine(list.Where(x => x == 40).First());
            Console.WriteLine(list.Where(x => x == 40).FirstOrDefault());
            */
            List<SimplePerson> list = new List<SimplePerson>();
            list.Add(new SimplePerson { Id = 101, Name = "Some Name" });
            list.Add(new SimplePerson { Id = 102, Name = "Some Vikash Name" });
            list.Add(new SimplePerson { Id = 103, Name = "Some Rakaesh" });

            //var result=list.Where(x => x.Id == 101).FirstOrDefault();
            //Console.WriteLine($"{result.Id} | {result.Name}");
            var result=list.Find(x => x.Id == 103);
            Console.WriteLine($"{result.Id} | {result.Name}");
            foreach (var item in list.Skip(2))
            {
                Console.WriteLine($"{item.Id} | {item.Name}");
            }
        }
    }
}
