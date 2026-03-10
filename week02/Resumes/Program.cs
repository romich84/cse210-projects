using System;
using System.ComponentModel.DataAnnotations;
using Resumes;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2.startYear = 2022;
        job2.endYear = 2023;
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}