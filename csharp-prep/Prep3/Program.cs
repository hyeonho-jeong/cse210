using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Randsom();
        int number = randomGenerator.Next(1,100);

        Console.Write("What is your magic number?");
        int guess = Console.ReadLine();

        if(guess != number)
        {
            while(guess == number)
            {
                if(guess > number)
                {
                    Console.Write("Lower");
                }
                else
                {
                    Console.Write("Higher");
                }
                Console.Write("What is your magic number?");
                int guess = Console.ReadLine();

            }
        }

        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}