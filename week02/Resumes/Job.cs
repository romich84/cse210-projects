using System;

namespace Resumes;

public class Job
{
   public string _company;
   public string _jobTitle;
   public int startYear;
   public int endYear;

   public void Display()
   {
      Console.WriteLine($"{_company}");
   }

   public void DisplayJobDetails()
   {
      Console.WriteLine($"{_jobTitle} ({_company}) {startYear}-{endYear}");
   }
}