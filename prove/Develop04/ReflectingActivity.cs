class ReflectingActivity : Activity
{

    private string actName = "Reflecting activity";

    private string discription = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";

    private int RandomNumber;

    private int RandomQuestion;

    private int num = 0;


    //adding new infront to do override
    new public void startingMessage()
    {
        Console.WriteLine($"Welcome to the {actName}\n");
    }

    //using override to use at child class
    new public void discriptionMessage()
    {
        Console.WriteLine($"{discription}\n");
    }    


    public void Randomprompt()
    {
        //Make a random number from 1 to 4
        Random randomGenerator = new Random();
        RandomNumber = randomGenerator.Next(1,5);

        Console.WriteLine("\nConsider the following prompt:");
        switch(RandomNumber)
        {
            case 1 :
                Console.WriteLine(" --- Think of a time when you stood up for someone else. ---");
                break;
            case 2 :
                Console.WriteLine(" --- Think of a time when you did something really difficult. ---");
                break;
            case 3 :
                Console.WriteLine(" --- Think of a time when you helped someone in need. ---");
                break;
            case 4 :
                Console.WriteLine(" --- Think of a time when you did something truly selfless. ---");
                break;
            case 5 :
                Console.WriteLine(" --- Who are some of your personal heroes? ---");
                break;
        }

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this expreience.");
        if(string.IsNullOrEmpty(userInput))
        {
            Console.Write("You may begin in: ");
            for(int i = 5; i>0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000); 
                    Console.Write("\b \b");                  
                }
        }
        Console.Clear();
    }

    public void questions(int sec)
    {
        //Make a random number from 1 to 9
        Random randomGenerator = new Random();
        RandomQuestion = randomGenerator.Next(1,9);
        
        List<string>question = new List<string>();
        question.Add("Why was this experience meaningful to you?");
        question.Add("Have you ever done anything like this before?");
        question.Add("How did you get started?");
        question.Add("How did you feel when it was complete?");
        question.Add("What made this time different than other times when you were not as successful?");
        question.Add("What is your favorite thing about this experience?");
        question.Add("What could you learn from this experience that applies to other situations?");
        question.Add("What did you learn about yourself through this experience?");
        question.Add("How can you keep this experience in mind in the future?");

        num = sec/10;

        while(num>0)
        {   
            Console.Write(question[RandomQuestion]);
            spinner2();
            Console.WriteLine("");
            num--;
            RandomQuestion = randomGenerator.Next(1,9);
        }
    }

    public void lastMessage(int seco)
    {
        Console.WriteLine($"You have completed {seco} seconds of the {actName}");
        spinner();
    }

    
}