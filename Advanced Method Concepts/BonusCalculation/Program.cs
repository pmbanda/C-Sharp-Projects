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
            //declare variables to be assigned in the methods as output reference
            double salary, bonus;
            int bonusInt;
            //invoke method and pass double as arguments
            Console.WriteLine("Arguments passed as double: ");
            SalaryBonusCalc(out salary, out bonus);

            Console.WriteLine();

            //invoke method and pass double and integer as arguments
            Console.WriteLine("Arguments passed as double and integer: ");
            SalaryBonusCalc(out salary, out bonusInt);

            Console.ReadLine();
        }

        static void SalaryBonusCalc(out double salary, out double bonus)
        {
            //assign values to the variables 
            salary = 600.00;
            bonus = 0.10;
            //declare the total variable
            double total;
            bonus *= 100;//convert bonus into a percentage 
            total = bonus + salary;//add the bonus to the salary and assign the value to the total variable

            //display the bonus salary and the total amount
            Console.WriteLine("Salary {0} ", salary);
            Console.WriteLine("Bonus {0} ", bonus);
            Console.WriteLine("Total {0} ", total.ToString("F"));

        }

        static void SalaryBonusCalc(out double salary, out int bonusInt)
        {
            //assign values to the variables 
            salary = 600.00;
            bonusInt = 50;
            //declare the total variable
            double total;
            total = bonusInt + salary;//add the bonus to the salary and assign the value to the total variable

            //display the bonus salary and the total amount
            Console.WriteLine("Salary {0} ", salary);
            Console.WriteLine("Bonus {0} ", bonusInt);
            Console.WriteLine("Total {0} ", total.ToString("F"));
        }
    }
}
