using System;

namespace ParameterPassing
{
    class Employee
    {

        private int idNumber;
        public int IdNumber { get; set; }

        private double salary;
        public double Salary { get; set; }
        public Employee() : this(9, 250000)
        {
            
        }

        public Employee(int id , double sal)
        {
            idNumber = id;
            salary = sal;
        }
        static void Main(string[] args)
        {
            Employee one = new Employee();
            Employee two = new Employee(10, 156000);
            Employee three = new Employee();

            Console.WriteLine("id {0} salary {1}", one.idNumber, one.salary);
            Console.WriteLine("id {0} salary {1}", two.idNumber, two.salary);

            Console.WriteLine();

            three.IdNumber = 200;
            three.Salary = 272772;
            Console.WriteLine("id {0} salary {1}", three.IdNumber, three.Salary);


        }
    }
}
