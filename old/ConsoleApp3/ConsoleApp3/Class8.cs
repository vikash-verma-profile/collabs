using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class NumberIsOdd : Exception
    {
        public NumberIsOdd(string message) : base(message)
        {

        }
    }
    internal class Class8
    {
        public static void Print()
        {
            throw new Exception("I am from Print");
        }
        public static void Main()
        {
            


            try
            {
                //throw new Exception("Hi I am ");
                Print();
                int a = 5;
                //if (a % 2 == 0)
                //{
                //    Console.WriteLine("Number is Even !");
                //}
                //else
                //{
                //    throw new NumberIsOdd("Number is odd");
                //}
                Console.WriteLine(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Hi I am being printed from finally block");
            }
        }
    }
}
