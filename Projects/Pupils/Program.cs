using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupils
{
    class Student
    {
        private const double RATE = 55.75;
        private string name;
        protected int credit;
        public double tuition;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual int Credit
        {
            get { return credit; }
            set
            {
                credit = value;
                tuition = credit * RATE;
            }
        }

        public double Tuition
        {
            get { return tuition; }
        }
    }
    class ScholarshipStudent : Student
    {
        public override int Credit
        {
            get { return credit; }
            set
            {
                credit = value;
                tuition = 0;
            }
        }
    }

    class program
    {
        static void Main()
        {
            Student payingStudent = new Student();
            //Student freeStudent = new Student();

            Student freeStudent;
            freeStudent = payingStudent;

            payingStudent.Name = "Megan";
            payingStudent.Credit = 15;
            freeStudent.Name = "Megan";
            freeStudent.Credit = 15;


            Console.WriteLine("{0}'s Tuition is {1}", payingStudent.Name, payingStudent.tuition.ToString("C"));
            Console.WriteLine("{0}'s Tuition is {1}", freeStudent.Name, freeStudent.tuition.ToString("C"));


            Console.WriteLine(payingStudent.GetHashCode());
            Console.WriteLine(freeStudent.GetHashCode());

            if (payingStudent.Equals(freeStudent))
                Console.WriteLine("Objects equal");
            else
                Console.WriteLine("Objects NOT equal");

        }
    }
}
