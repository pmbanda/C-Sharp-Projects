using System;

namespace EmployeesReadOnlyDemo
{
        
    class Employee
    {
        public int idNumber;
        public Employee()
        {
            idNumber++;
        }
        
        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
    }

    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee myAssistant = new Employee();
            Employee myDriver = new Employee();

            Console.WriteLine(myAssistant.idNumber);
            Console.WriteLine(myDriver.idNumber);

            //myAssistant.IdNumber = 3456;
            //Employee myAssistant = new Employee(3456);

            //Console.WriteLine(myAssistant.IdNumber);
            Console.ReadLine();
        }
    }
}
