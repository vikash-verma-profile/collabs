using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class Class9
    {
        public static void Main12()
        {
            string filePath = "sample.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exits");
                string[] readData = File.ReadAllLines(filePath);
                foreach (var item in readData)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("File does not exits");
            }
        }
    }
}
