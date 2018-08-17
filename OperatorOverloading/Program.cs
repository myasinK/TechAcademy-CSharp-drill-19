using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee
    {
        public int Id;
        public static bool operator == (Employee employee_1, Employee employee_2)
        {
            return employee_1.Id == employee_2.Id;
        }
        public static bool operator != (Employee employee_1, Employee employee_2)
        {
            return employee_1.Id != employee_2.Id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee();
            Employee employee_2 = new Employee();
            employee_1.Id = 1;
            employee_2.Id = 5;
            Console.WriteLine("Employee 1 ID:" + employee_1.Id);
            Console.WriteLine("Employee 2 ID:" + employee_2.Id);
            Console.WriteLine("employee 1 == employee 2 ? " + Convert.ToString( employee_1 == employee_2 ));
            Console.WriteLine("employee 1 != employee 2 ? " + Convert.ToString( employee_1 != employee_2 ));
        }
    }
}
