using System;
using static System.Console;

namespace CreateStudent3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[8];
            int x;
            int id;
            string name;
            double gpa;

            for (x = 0; x < students.Length; ++x)
            {
                GetData(out id, out name, out gpa);
                students[x] = new Student(id, name, gpa);
            }

            Array.Sort(students);
            WriteLine("Sorted List: ");

            for (x = 0; x < students.Length; ++x)
                Display(students[x]);
          
        }

        static void Display(Student student)
        {
            WriteLine(" {0,-10} {1,-10} {2,-10}", student.Id, student.Name, student.Gpa );
        }

        static void GetData(out int id, out string name, out double gpa)
        {
            string inString;
            Write("Please enter student ID number >> ");
            inString = ReadLine();
            int.TryParse(inString, out id);
            Write("Please enter last name for student {0} >> ", id);
            name = ReadLine();
            Write("Please enter grade point average >> ");
            inString = ReadLine();
            double.TryParse(inString, out gpa);
        }
    }

    class Student : IComparable
    {
        public double Gpa { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name, double gpa)
        {
            this.Id = id;
            this.Name = name;
            this.Gpa = gpa;
        }


        public int CompareTo(object obj)
        {
            int returnVal;
            Student temp = (Student)obj;
            if (this.Id > temp.Id)
                returnVal = 1;
            else
                if (this.Id < temp.Id)
                returnVal = -1;
            else
                returnVal = 0;
            return returnVal;
        }
    }
}