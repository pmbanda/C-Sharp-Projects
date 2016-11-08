using System;
using static System.Console;
//Author:   Peter Eugene Mbanda
//Date:     3/7/2016  
//Purpose:  

namespace DemoJobs2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create several job instances
            Job2 job1 = new Job2("House Painting ", 10, 100);
            Job2 job2 = new Job2("Dog Walking ", 1, 10);
            Job2 job3 = new Job2("Chop wood ", 20, 15);
            Job2 job4 = new Job2("Guard Dogs ", 5, 10);

            Job2 job5 = job1 + job2;//add two jobs 
            WriteLine("Job1 added to Job2");
            WriteLine("Job Description: {0} ", job5.Description);
            WriteLine("Job completion Time: {0} ", job5.CompletionTimeHrs);
            WriteLine("Job Rate: {0} ", job5.RateCharge);
            WriteLine("Total: {0} ", job5.Total.ToString("C"));

            WriteLine();

            Job2 job6 = job3 + job4;//add two jobs 
            WriteLine("Job3 added to Job4");
            WriteLine("Job Description: {0} ", job6.Description);
            WriteLine("Job completion Time: {0} ", job6.CompletionTimeHrs);
            WriteLine("Job Rate: {0} ", job6.RateCharge);
            WriteLine("Total: {0} ", job6.Total.ToString("C"));

            ReadLine();
        }
    }
    class Job2
    {
        //create class field properties
        public string Description { get; set; }
        public double CompletionTimeHrs { get; set; }
        public double RateCharge { get; set; }
        public double Total
        {
            //total obtained through multiplication
            //of rate of charge and completion time in hours
            get { return (this.RateCharge * this.CompletionTimeHrs); }
        }
        public Job2(string description, double completionTime, double rate)
        {
            //assign the parameter values to the class properties
            this.Description = description;
            this.CompletionTimeHrs = completionTime;
            this.RateCharge = rate;
        }

        public static Job2 operator +(Job2 one, Job2 two)
        {
            //create new variables to hold values for the new object
            string newDescriptions = one.Description + " and " + two.Description;
            double newTime = one.CompletionTimeHrs + two.CompletionTimeHrs;
            double newRate = (one.RateCharge + two.RateCharge) / 2.0;
            return new Job2(newDescriptions, newTime, newRate);//return object to the calling method
        }
    }
}

