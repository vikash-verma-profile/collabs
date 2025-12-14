namespace SampleProject
{

    public class Vehicle
    {

        protected int VehicleNo;
        protected string Make;
        //public Vehicle(int VehicleNo, string Make)
        //{
        //    this.VehicleNo = VehicleNo;
        //    this.Make = Make;
        //}
        //public Vehicle()
        //{

        //}
        //public void Print()
        //{
        //    Console.WriteLine($"{VehicleNo} : {Make}");
        //}
    }
    public class Bike : Vehicle
    {
        private string Model;
        //public Bike(int VehicleNo, string Make, string Model) : base(VehicleNo, Make)
        //{
        //    this.Model = Model;
        //}

        public void GetData()
        {
            VehicleNo = int.Parse(Console.ReadLine());
            Make = Console.ReadLine();
            Model = Console.ReadLine();
        }
        public void PrintData()
        {
            Console.WriteLine($"{VehicleNo}-{Make}-{Model}");
        }

    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Bike student = new Bike();
            student.GetData();
            student.PrintData();
        }
    }
}