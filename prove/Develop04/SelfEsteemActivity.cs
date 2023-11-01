class SelfEsteemActivity : Activity
{
    private string discription = "This activity will be an opportunity to see how precious you are. \nYou can increase your self-esteem by sharing love with others.";

    private int RandomNumber;
    private int RandomQuestion;

    public SelfEsteemActivity(string activityName)
    {
        _activityName = activityName;
    }

    //adding new infront to do override
    new public void startingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n");
    }

    //using override to use at child class
    new public void discriptionMessage()
    {
        Console.WriteLine($"{discription}\n");
    }  

     public void Randomprompt(int sec)
    {
        //Make a random number from 1 to 8
        Random randomGenerator = new Random();
        RandomQuestion = randomGenerator.Next(1,8);
        
        List<string>question = new List<string>();
        question.Add("You are enough jus as you are.");
        question.Add("All our dreams can come true. If we have the courage to pursure them.");
        question.Add("The only way to achieve the impossible is to beleive it is possible.");
        question.Add("Although the world is full of suffering, it is full also of the overcoming of it.");
        question.Add("It is only with the heart that one can see rightly what is essential is invisible to the eye.");
        question.Add("You can't someone love if you don't love yourself first");
        question.Add("Life will knock you down more than you can imagine. Don't knock yourself down.");
        question.Add("Act as if what you do makes a difference. It does.");

        Console.WriteLine("\nThink about this message:\n");
        Console.WriteLine(question[RandomQuestion]);
        Console.WriteLine("\nPress enter if you deeply think about this message.\n");
        string userInt = Console.ReadLine();
        if(string.IsNullOrEmpty(userInt))
        {
            Console.Clear();
            Console.WriteLine("\nThink about who needs this message the most among your friends or family.");
         for(int i=sec/3; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        Console.WriteLine("\nThink about why the person you thought would need this message.");
        for(int i=sec/3; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        Console.WriteLine("\nThink about how to express this message to others");
        for(int i=sec/3; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        if(string.IsNullOrEmpty(userInput))
        {
            Console.Clear();
            Console.WriteLine("\nYour little attention makes miracles.");
        }
        
    }

    public void lastMessage(int seco)
    {
        Console.WriteLine($"You have completed {seco} seconds of the {_activityName}");
        spinner();
    }

}