using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
        public int Id;
        public static bool operator == (Employee<T> employee_1, Employee<T> employee_2)
        {
            return employee_1.Id == employee_2.Id;
        }
        public static bool operator != (Employee<T> employee_1, Employee<T> employee_2)
        {
            return employee_1.Id != employee_2.Id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee_1 = new Employee<string>();
            Employee<string> employee_11 = new Employee<string>();
            Employee<int> employee_2 = new Employee<int>();
            Employee<int> employee_22 = new Employee<int>();
            employee_1.Id = 1;
            employee_2.Id = 5;
            employee_1.Things = new List<string>( new string[] { "one", "two", "three", "four" } );
            foreach ( string thing in employee_1.Things )
            {
                Console.WriteLine(thing);
            }
            employee_2.Things = new List<int>( new int[] { 1, 2, 3, 4 } );
            foreach ( int thing in employee_2.Things )
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("Employee 1 ID:" + employee_1.Id);
            Console.WriteLine("Employee 2 ID:" + employee_2.Id);
            Console.WriteLine("employee 1 == employee 2 ? " + Convert.ToString( employee_1 == employee_11 ));
            Console.WriteLine("employee 1 != employee 2 ? " + Convert.ToString( employee_2 != employee_22 ));
        }
    }
}
