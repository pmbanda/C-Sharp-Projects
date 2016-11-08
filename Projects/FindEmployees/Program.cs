using Employee;
using System;
using System.IO;
using static System.Console;

namespace FindEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            const char DELIM = ',';
            const int END = 999;
            const string FileName = "EmployeeData.txt";
            Employees emp = new Employees();

            FileStream inFile = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] fields;
            double minSalary;

            Write("Enter minimum salary to find or " + END + " to quit >> ");
            minSalary = Convert.ToDouble(ReadLine());

            while(minSalary != END)
            {
                WriteLine("\n{0, -5}{1, -12}{2, 8}","Num","Name","Salary");
                inFile.Seek(0, SeekOrigin.Begin);
                recordIn = reader.ReadLine();

                while (recordIn != null)
                {
                    fields = recordIn.Split(DELIM);
                    emp.Number = Convert.ToInt32(fields[0]);
                    emp.Name = fields[1];
                    emp.Salary = Convert.ToDouble(fields[2]);
                    if(emp.Salary >= minSalary)
                        WriteLine("\n{0, -5}{1, -12}{2, 8}", emp.Number, emp.Name, emp.Salary.ToString("C"));
                    recordIn = reader.ReadLine();
                }

                Write("Enter minimum salary to find or " + END + " to quit >> ");
                minSalary = Convert.ToDouble(ReadLine());

            }

            reader.Close();
            inFile.Close();

            



        }
    }
}
