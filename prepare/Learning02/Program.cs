using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Network Administrator";
        job1._company = "Westring Technologies";
        job1._startYear = 2011;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Network Engineer";
        job2._company = "Directpointe";
        job2._startYear = 2008;
        job2._endYear = 2011;

        Resume resume1 = new Resume();
        resume1._name = "Tagg McDonald";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}