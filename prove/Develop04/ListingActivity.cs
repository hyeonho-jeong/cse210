class ListingActivity : Activity
{

    private string discription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private int RandomNumber;

    private int count = 0;

    public ListingActivity(string activityName)
    {
        _activityName = activityName;
    }

    new public void startingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n");
    }

    //using override to use at child class
    new public void discriptionMessage()
    {
        Console.WriteLine($"{discription}\n");
    }    


    public void Randomprompt()
    {
        //Make a random number from 1 to 5
        Random randomGenerator = new Random();
        RandomNumber = randomGenerator.Next(1,6);

        Console.WriteLine("List as many responses you can to the foloowing prompt:\n");

        switch(RandomNumber)
        {
            case 1 :
                Console.WriteLine(" --- Who are people that you appreciate? ---");
                break;
            case 2 :
                Console.WriteLine(" --- What are personal strengths of yours? ---");
                break;
            case 3 :
                Console.WriteLine(" --- Who are people that you have helped this week? --- ");
                break;
            case 4 :
                Console.WriteLine(" --- When have you felt the Holy Ghost this month? --- ");
                break;
            case 5 :
                Console.WriteLine(" --- Who are some of your personal heroes? --- ");
                break;
        }

        Console.Write("\nYou may begin in: ");
        for(int i = 5; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000); 
                Console.Write("\b \b");                  
            }    
    }

    public void answer(int sec)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sec);

        while(DateTime.Now < endTime)
        {
            // Only hand control over to readline if there is currently 
            // something in the feed; otherwise, we will assume they
            // are finished and don't want to type anything.
            if (Console.KeyAvailable) {
                string userInput = Console.ReadLine();
                if(!string.IsNullOrEmpty(userInput))
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"You listed {count} items!");
        
    }

    public void lastMessage(int seco)
    {
        Console.WriteLine($"You have completed {seco} seconds of the {_activityName}");
        spinner();
    }
}