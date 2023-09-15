using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congraturation!");
        }
        else
        {
            Console.WriteLine("You can make it next time!");
        }
    }
}