using System;
using System.Formats.Asn1;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letterGrade = "";

        if (grade >=90)
        {
            letterGrade = "A";
        }

        else if (grade >=80)
        {
            letterGrade = "B";
        }

        else if (grade >=70)
        {
            letterGrade = "C";
        }

        else if (grade >=60)
        {
            letterGrade = "D";
        }

        else 
        {
            letterGrade = "F";
        }
        

        Console.WriteLine($"Your letter grade is: {letterGrade}");
        if (grade >=70)
        {
            Console.WriteLine("You Passed the Course Congratulations");
        }
        else
        {
            Console.WriteLine("You failed the course, try again next time!");
        }
    }
}