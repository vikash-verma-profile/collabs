namespace ConsoleApp3
{
    internal class Program
    {
        /// <summary>
        /// asjhdga sjhd gasjhd gas jhd gv
        /// </summary>
        /// <param name="args"></param>
        static void Main1(string[] args)
        {
            int a, b;
            a = 1;
            b = 2;
             int result;
            Sum(ref a,ref b,out result);
             Console.WriteLine(result);
            /*
             */

            //Sum(ref a, ref b);
            X(b:1,a:4);
            Console.WriteLine("Hello, World!");
        }

        public static void X(in int a,int b,int c=6)
        {
            Console.Write(a+b);
        }

        public static void Sum(ref int a,ref int b,out int c)
        {
            c = a + b;
            //Console.WriteLine(a + b);
        }
    }
}