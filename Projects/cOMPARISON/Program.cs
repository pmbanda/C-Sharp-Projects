using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class ComparableEmployeeArray
    {
        static void Main(string[] args)
        {
            int firstId = 20;
            double firstSalary = 10000;

            Employee[] empArray = new Employee[5];
            int x;

            for (x = 0; x < empArray.Length; x++)
            {
                empArray[x] = new Employee() { IdNumber = firstId, Salary = firstSalary };
                firstId -= 1;
                firstSalary += 500;
            }
                

            //empArray[0].IdNumber = 333;
           // empArray[1].IdNumber = 444;
           // empArray[2].IdNumber = 555;
            //empArray[3].IdNumber = 111;
            //empArray[4].IdNumber = 222;


            Employee seekEmployee = new Employee();
            seekEmployee.IdNumber = 222;

            Array.Sort(empArray);

            Console.WriteLine("Sorted Employees: ");

            for (x = 0; x < empArray.Length; x++)
                Console.WriteLine("Employee#{0}: {1} {2}", x, empArray[x].IdNumber, empArray[x].Salary.ToString("C"));

            x = Array.BinarySearch(empArray, seekEmployee);

            Console.WriteLine("Employee#{0} was found at position {1}", seekEmployee.IdNumber , x);

            Console.WriteLine();

            Employee employee1 = new Employee() {IdNumber = 27, Salary = 100000 };
            Worker worker2 = new Worker() { IdNumber = 36, Salary = 200000 };

            
            int answer = employee1.CompareTo(worker2);
            Console.WriteLine("Result " + answer);
        }
    }

    class Employee : IComparable
    {
        public int IdNumber { get; set; }
        public double Salary { get; set; }


        public int CompareTo(Object obj)
        {
            int returnVal;
            Employee temp = (Employee)obj;
            if (this.IdNumber > temp.IdNumber)
                returnVal = 1;
            else
                if (this.IdNumber < temp.IdNumber)
                    returnVal = -1;
                else
                    returnVal = 0;
            return returnVal; 
        }
    }
    class Worker: Employee{}
}
