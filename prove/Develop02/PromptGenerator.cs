using System.Diagnostics.Contracts;
using System.Dynamic;

class PromptGenerator : Entry
{ 
    public string prompt{get; set;}
    //public string answer{get; set;}
    //public string time{get; set;}

    private int _randomNumber;  //This is for random number
   
    public int MakeRandomNumber() //a function for making random number for prompt
    {
        Random randomGenerator = new Random();
        _randomNumber = randomGenerator.Next(1,6);

        return _randomNumber;
    } 
   
    public void RandomPrompt()  //A function for making random prompt
    {
        MakeRandomNumber();
        switch(_randomNumber)
        {
            case 1 :
                prompt = "Who was the most intereting person I interacted with today?";
                Console.WriteLine(prompt);
                break;
            case 2 :
                prompt = "What was the best part of my day?";
                Console.WriteLine(prompt);
                break;
            case 3 :
                prompt = "How did I see the hand of the Lord in my life today?";
                Console.WriteLine(prompt);
                break;
            case 4 :
                prompt = "What was the strongest emotion I felt today?";
                Console.WriteLine(prompt);
                break;
            case 5 :
                prompt = "If I have one thing I could do over today, what would it be?";
                Console.WriteLine(prompt);
                break;
        }
    }

    
    public void RandomMessage()//Make a function for list 
    {
        MakeRandomNumber();
         switch(_randomNumber)
        {
            case 1 :
                Console.WriteLine("One foot forward. One day at a time.");
                break;
            case 2 :
                Console.WriteLine("You are a wonderful person!");
                break;
            case 3 :
                Console.WriteLine("MOve forward, good things are up ahead!");
                break;
            case 4 :
                Console.WriteLine("You are a child of Heavenly Father! Don't give up!");
                break;
            case 5 :
                Console.WriteLine("I may not be there yet, but I am closer than I was yesterday!");
                break;
        }

    }

     //Make a function for list 
     public void DisplayPrompt()
     {
        Console.WriteLine($" - Promt:{time} {prompt}: {answer}");
     }
    
}