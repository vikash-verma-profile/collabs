using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class SortedListExample
    {
        public static void Main15()
        {
            SortedList<int,string> sortedListStore = new SortedList<int, string>();
            sortedListStore.Add(1,"Vikash");
            sortedListStore.Add(9, "Vikash 9");
            sortedListStore.Add(6, "Vikash 6");
            foreach (var item in sortedListStore)
            {
                Console.WriteLine(item);
            }

            SortedList<string, string> sortedListAlp = new SortedList<string, string>();
            sortedListAlp.Add("vikash", "My Name is vikash");
            sortedListAlp.Add("Vikash","My Name is Vikash");
            sortedListAlp.Add("Akash", "My Name is Akash");
            sortedListAlp.Add("Yassir", "My Name is Yassir");
            foreach (var item in sortedListAlp)
            {
                Console.WriteLine(item);
            }


        }
    }
}
