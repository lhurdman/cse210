using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letterGrade = "";

        if (percent >= 90)
        {
            letterGrade = "A";
        }
        else if (percent >= 80)
        {
            letterGrade = "B";
        }
        else if (percent >= 70)
        {
            letterGrade = "C";
        }
        else if (percent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is a {letterGrade}");
        if (percent < 70)
        {
            Console.WriteLine("Your grade did not meet the 70% requirement, better luck next time. ");
        }
        else
        {
            Console.WriteLine("Congrats! Your grade met the 70% requirement!");
        }
        
        
    }
}