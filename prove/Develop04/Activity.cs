class Activity
{
    protected string _activityName = "";

    protected string _discription = "";

    public string duration{get; set;}

    //make a number for count time.
    private int countTime;

    public void startingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}");
    }

    public void discriptionMessage()//using override to use at child class
    {
        Console.WriteLine($"{_discription}\n");
    }

    public void endingMessage(int sec)
    {
        Console.WriteLine("\n\nWell done!!");
        spinner();
        Console.WriteLine($"You have completed {sec} seconds of the {_activityName}");
        spinner();
        

    }

    public void spinner()
    {
        List<string>animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");

        foreach(string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }
    }

        public void spinner2()
    {
        List<string>animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string a = animationStrings[i]; 
            Console.Write(a);
            Thread.Sleep(800);
            Console.Write("\b \b");
            i++;

            if(i>=animationStrings.Count)
            {
                i = 0;
            }
        }
             
    }

    //Asking input from user
    public int countDown()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string sec = Console.ReadLine();
        countTime = int.Parse(sec);   

        return countTime;     
    }

}