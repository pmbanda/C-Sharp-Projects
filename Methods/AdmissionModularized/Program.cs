using System;
using static System.Console;

namespace AdmissionModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the local variables 
            double grade;
            Int32 score;

            //prompt the user for the gpa and score
            Write("Enter the students GPA: ");
            grade = Convert.ToDouble(ReadLine());

            Write("Enter the students score: ");
            score = Convert.ToInt32(ReadLine());

            //display the admission status whether accepted or rejected
            WriteLine("Admission status >> {0}", verifyAcceptance(grade, score));

            ReadLine();
        }
        static string verifyAcceptance(double gpa, Int32 points)
        {
            //if gpa is greater than 3.0 and score >= 60 display accept
            if (gpa >= 3.0 && points >= 60)
                return "Accept";
            //if gpa is less than 3.0 and score >= 80 display accept
            else if (gpa < 3.0 && points >= 80)
                return "Accept";
            //if the conditions do not match the above criteria display reject 
            else
                return "Reject";
        }
    }
}
