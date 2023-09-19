using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        Console.Write("What is your magic number?");
        int guess = int.Parse(Console.ReadLine());

        while(guess != number)
        {
            if(guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.Write("What is your magic number?");
            guess = int.Parse(Console.ReadLine());
        }
    
        Console.WriteLine("You guessed it!");

    }
}