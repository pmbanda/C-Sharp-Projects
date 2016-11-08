//Author:   Peter Eugene Mbanda
//Date:     1/14/2016
//Purpose:  Payroll calculator
using System;
using static System.Console;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            const double fedRate = 15 / 100.0;
            const double stateRate = 5 / 100.0;

            //prompt the user for name , social number , hourly rate and the hours worked 
            Write("Enter your name: ");
            string name = ReadLine();
            Write("Social security number: ");
            string social = ReadLine();
            Write("Hourly payrate: ");
            double hourlyRate = Convert.ToDouble(ReadLine()); 
            Write("Hours worked: ");
            double hoursWorked = Convert.ToDouble(ReadLine());

            WriteLine();///empty line for readability
            //display the users info 
            WriteLine("Payroll summary for: " + name);
            WriteLine("SSN: " + social);
            WriteLine("You worked " + hoursWorked + " hours at " + hourlyRate.ToString("C2") + " per hour ");

            WriteLine();
            //calculate the gross pay , federal tax and state tax
            double grossPay = hourlyRate * hoursWorked;
            double federalTax = grossPay * fedRate;
            double stateTax = grossPay * stateRate;
            //calculate the net pay 
            double netPay = grossPay - (federalTax + stateTax);

            //display the results 
            WriteLine("Gross pay: {0,22}", grossPay.ToString("C2"));
            WriteLine("Federal withholding: {0,12}", federalTax.ToString("C2"));
            WriteLine("State withholding: {0,14}", stateTax.ToString("C2"));
            WriteLine("----------------------------------------");
            WriteLine("Net pay: {0,24}", netPay.ToString("C2"));

            WriteLine();
            ReadLine();
        }
    }
}
