using System;

namespace FieldProperty
{
    class Trial
    {
        private int idNumber;

        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }

        static void Main(string[] args)
        {
            Trial t = new Trial();
            t.IdNumber = 22;
            Console.WriteLine("Id number is " + t.IdNumber);

        }
    }
    
}
