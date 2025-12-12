using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public override string ToString()
        {
            return $"{EmployeeId}-{EmployeeName}";
        }
    }

    internal class Class6
    {
        public static void Main8()
        {
            int numberOfEmployees=int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            Dictionary<int,Employee> dist = new Dictionary<int,Employee>();
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Employee employee = new Employee();
                employee.EmployeeId = int.Parse(Console.ReadLine());
                employee.EmployeeName = Console.ReadLine();
                list.Add(employee);
                dist.Add(employee.EmployeeId, employee);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==========From Dictionay====");
            foreach (var item in dist)
            {
                Console.WriteLine(item.Key+"- "+item.Value.EmployeeName);
            }


        }
    }
}
