using System;
using System.IO;
using static System.Console;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace Serializabledemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string FileNAME = "Data.ser";
            Employee emp = new Employee();

            FileStream outFile = new FileStream(FileNAME, FileMode.Create, FileAccess.Write);

            BinaryFormatter bFormatter = new BinaryFormatter();

            Write("Enter employee number or " + END + " to quit >> ");
            emp.Number = Convert.ToInt32(ReadLine());

            while(emp.Number != END)
            {
                Write("Enter last name >> ");
                emp.Name = ReadLine();
                Write("Enter Salary >> ");
                emp.Salary = Convert.ToDouble(ReadLine());
                bFormatter.Serialize(outFile, emp);

                Write("Enter employee number or " + END + " to quit >> ");
                emp.Number = Convert.ToInt32(ReadLine());
            }

            outFile.Close();

            FileStream inFile = new FileStream(FileNAME, FileMode.Open, FileAccess.Read);
            WriteLine("\n{0, -5}{1, -12}{2, 8}", "Num","Name","Salary");

            while (inFile.Position < inFile.Length)
            {
                emp = (Employee)bFormatter.Deserialize(inFile);
                WriteLine("\n{0, -5}{1, -12}{2, 8}", emp.Number,emp.Name,emp.Salary.ToString("C"));
            }
            inFile.Close();
        }
    }

    [Serializable]
    internal class Employee
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double  Salary { get; set; }
        public Employee()
        {

        }
    }
}
