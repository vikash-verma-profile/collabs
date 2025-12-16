using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class Class8
    {
       public async static  Task DownloadFileAsync() {
            Console.WriteLine("I am downloading a file");
            Thread.Sleep(1000);
            //return "Some Value";
        }
        public static void Main(string[]args)
        {
            //await DownloadFileAsync();
            Task.Run(() => DownloadFileAsync());
            Console.WriteLine("Main ended here");
        }
    }
}
