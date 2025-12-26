using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class Calc
    {
        int Number;

        public Calc(int Number)
        {
                this.Number=Number;
        }
        public Calc()
        {

        }
        public static Calc operator +(Calc c1, Calc c2)
        {
            Calc c3 = new Calc();
            c3.Number = c1.Number + c2.Number;
            return c3;
        }

        public void Print()
        {
            Console.WriteLine(Number);
        }
    }
    internal class Class5
    {
        public void Sum()
        {

        }
        //public string Sum()
        //{
        //    return "";
        //}
        public void Sum(int a,int b)
        {

        }
        public void Sum(int a, int b,int c)
        {

        }
        public void Sum(double a, double b, double c)
        {

        }
        public static void Main13()
        {
            Class5 class5=new Class5();
            class5.Sum(1,2);
            class5.Sum(1, 2,3);
            class5.Sum(1.03, 2, 3);

            Calc c3= new Calc();
            Calc c1 = new Calc(5);
            Calc c2 = new Calc(5);
            c3 = c1 + c2;//--
            c3.Print();
        }
    }
}
