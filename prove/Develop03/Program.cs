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


        Console.Clear();//Make the screen empty       
        reference.GetRenderedText();//show the reference and scritpure
        scripture.DisplayScripture();
       
        while(true)//make a loop for get enter or input quit
        {
           Console.WriteLine(" ");
           Console.WriteLine("Press enter to hide a word or type quit to exit:");
           string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "quit")// If the user types quit, end the program
            {
                break;
            }
            
            else if(string.IsNullOrEmpty(userInput))//If the user click enter, made the scripture blank
            {
                 
                Console.Clear();// Clear the console screen
                scripture.HideWord();
                reference.GetRenderedText();
                scripture.DisplayScripture();

                
                if(scripture.AllWordHidden())//check if all words have been hidden
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