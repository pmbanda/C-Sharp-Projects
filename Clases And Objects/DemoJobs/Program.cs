using System;
using static System.Console;
//Author:   Peter Eugene Mbanda
//Date:     3/7/2016  
//Purpose:  

namespace DemoJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            //create several job instances
            Job job1 = new Job("Carpet Cleaning ", 1.2, 5);
            Job job2 = new Job("Website Maintenance ", 3.5, 36);
            Job job3 = new Job("Chop wood ", 20, 15);
            Job job4 = new Job("Guard Dogs ", 5, 10);

            Job jobNew = job3 + job4;//add two jobs 
            WriteLine("Job3 added to job4");
            WriteLine("Job Description: {0} ", jobNew.Description);
            WriteLine("Job completion Time: {0} ", jobNew.CompletionTimeHrs);
            WriteLine("Job Rate: {0} ", jobNew.RateCharge);
            WriteLine("Total: {0} ", jobNew.Total.ToString("C"));

            ReadLine();
        }
    }
    class Job
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
        public Job(string description, double completionTime, double rate)
        {
            //assign the parameter values to the class properties
            this.Description = description;
            this.CompletionTimeHrs = completionTime;
            this.RateCharge = rate;
        }

        public static Job operator+(Job one, Job two)
        {
            //create new variables to hold values for the new object
            string newDescriptions = one.Description + " and " + two.Description;
            double newTime = one.CompletionTimeHrs + two.CompletionTimeHrs;
            double newRate = (one.RateCharge + two.RateCharge) / 2.0;
            return new Job(newDescriptions, newTime, newRate);//return object to the calling method
        }
    }
}
