using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2021;
        job1.JobDisplay();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2021;
        job2._endYear = 2022;
        job2.JobDisplay();

        Resume myResume = new Resume();
        myResume._name = "Richmond Uyi";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);
        myResume.Display();

    }
}