using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Tree
    {
        public int Id { get; set; }
        public string Location { get; set; }
    }
    internal class ListCollectionExample
    {
        public static void Main14()
        {
            List<Tree> listData=new List<Tree>();
            Tree tree = new Tree();
            tree.Id = 1;
            tree.Location = "Bhuvnaswer";
            listData.Add(tree);
            listData.Add(new Tree() { Id = 2, Location = "Banglore" });
           // listData.Add(new Tree() { Id = 3, Location = Console.ReadLine() });
            foreach (var item in listData)
            {
                Console.WriteLine($"{item.Id}-{item.Location}");
            }

            Console.WriteLine("===Update==");
           
            if (listData.Contains(tree))
            {
               listData.Remove(tree);
               Tree tree1 = new Tree();
                tree1.Id = 1;
                tree1.Location = "Delhi";
               listData.Add(tree1);
            }
            foreach (var item in listData)
            {
                Console.WriteLine($"{item.Id}-{item.Location}");
            }


        }
    }
}
