using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //call the constructor from class Reference
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        //call the constructor from class Scripture
        Scripture scripture = new Scripture( "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknoledge him, and he shall direct thy paths." );


        //Make the screen empty
        Console.Clear();
        //show the reference and scritpure
        reference.GetRenderedText();
        scripture.DisplayScripture();

        //make a loop for get enter or input quit
        while(true)
        {
           Console.WriteLine(" ");
           Console.WriteLine("Press enter to hide a word or type quit to exit:");
           string userInput = Console.ReadLine();
            // If the user types quit, end the program
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            //If the user click enter, made the scripture blank
            else if(string.IsNullOrEmpty(userInput))
            {
                 // Clear the console screen
                Console.Clear();
                scripture.HideWord();
                reference.GetRenderedText();
                scripture.DisplayScripture();

                //check if all words have been hidden
                if(scripture.AllWordHidden())
                {
                    break;
                }
            }
            //if the user input something instead of quit or enter, print error message 
            else
            {
                Console.WriteLine("You put something wrong. Please try again.");
            }
        }
    }
} 