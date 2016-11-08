using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorsDemo
{
    class Employee
    {
        public int idNumber { get; set; }
        public Employee(int empId)
        {
            idNumber = empId;
            Console.WriteLine("Employee object {0} created", idNumber);
        }
        ~Employee()
        {
            Console.WriteLine("Employee object {0} destroyed", idNumber);
        }
    }
    class DemoEmployeeDestructor
    {
        static void Main()
        {
            Employee aWorker = new Employee(101);
            Employee aWorker2 = new Employee(202);
        }
    }
}
