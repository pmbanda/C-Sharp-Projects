/*Author:   Peter Eugene Mbanda
**Date:     2/12/2016
**Purpose:  Application to Calculate bonus for employees and total salary
**
**@all rights reserved
**@not for unauthorised use
*/
using System;

namespace BonusCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //  declare variables to be assigned in the methods as output reference
            double salary, bonus;
            int bonusInt;

            //  invoke method and pass two double values as arguments
            Console.WriteLine("Arguments passed as double: ");
            SalaryBonusCalc(out salary, out bonus);

            Console.WriteLine();

            //  invoke method and pass double and integer as arguments
            Console.WriteLine("Arguments passed as double and integer: ");
            SalaryBonusCalc(out salary, out bonusInt);

            Console.ReadLine();
        }

        static void SalaryBonusCalc(out double salary, out double bonus)
        {
            // declare and assign values to the variables 
            double total;
            salary = 600.00;
            bonus = 0.10;

            // convert bonus into a percentage 
            bonus *= 100;

            // add the bonus to the salary and assign the value to the total variable
            total = bonus + salary;

            // display the bonus salary and the total amount
            Console.WriteLine("Salary {0} ", salary.ToString("C"));
            Console.WriteLine("Bonus {0} ", bonus.ToString("C"));
            Console.WriteLine("Total {0} ", total.ToString("C2"));

        }

        static void SalaryBonusCalc(out double salary, out int bonusInt)
        {
            // declare and assign values to the variables 
            double total;
            salary = 600.00;
            bonusInt = 50;

            // add the bonus to the salary and assign the value to the total variable
            total = bonusInt + salary;

            // display the bonus salary and the total amount
            Console.WriteLine("Salary {0} ", salary.ToString("C"));
            Console.WriteLine("Bonus {0} ", bonusInt.ToString("C"));
            Console.WriteLine("Total {0} ", total.ToString("C2"));
        }
    }
}
