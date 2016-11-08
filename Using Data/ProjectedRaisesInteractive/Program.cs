/*Author:   Peter Eugene Mbanda
 *Date:       1/8/2016
 *Purpose:    Projected Raises interactive application 
*/
using System;
using static System.Console;

namespace ProjectedRaisesInteractive
{
    class Program
    {
        const double RAISE_RATE = 4 / 100.00;
        static void Main(string[] args)
        {
            //local level variables declaration for the employee salaries
            double sal1, sal2, sal3;

            Write("Enter employee 1 salary >> ");//emoployee 1 salary prompt 
            sal1 = Convert.ToDouble(ReadLine());

            Write("Enter employee 2 salary >> ");//emoployee 2 salary prompt 
            sal2 = Convert.ToDouble(ReadLine());

            Write("Enter employee 3 salary >> ");//emoployee 3 salary prompt 
            sal3 = Convert.ToDouble(ReadLine());

            WriteLine();//white space

            //multiply the salary with the rate increase and assign the result back to the salary 
            //with the new projection 
            sal1 += sal1 * RAISE_RATE;
            sal2 += sal2 * RAISE_RATE;
            sal3 += sal3 * RAISE_RATE;

            //display the new projected salaries 
            WriteLine("Projected salaries ");
            WriteLine("Employee 1: {0} ", sal1.ToString("C2"));
            WriteLine("Employee 2: {0} ", sal2.ToString("C2"));
            WriteLine("Employee 3: {0} ", sal3.ToString("C2"));

            ReadLine();
        }
    }
}
