using System;

class Program
{
    static void Main(string[] args)
    {
        float gradePercentage;
        string letterGrade;
        string userinput;
        string passFail;

        Console.Write("What is your grade percentage? ");
        userinput = Console.ReadLine();
        gradePercentage = float.Parse(userinput);

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (gradePercentage >= 70)
        {
            passFail = "You passed the course!";
        }
        else
        {
            passFail = "You did not pass the course. Remember to study more.";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}");
        Console.WriteLine(passFail);

    }
}