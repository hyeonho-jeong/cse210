class BreathingActivity : Activity
{
    private string actName = "Breathing activity";

    private string discription = "This activity will help your relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";

    private  int dece;
    private  int breathIn;
    private  int breathOut; 




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


    //breath in time will be 6 sec, breath out time will be 4 sec.
    public void breathTime(int sec)
    {
        //if total breath time is not devided 10, 
        //the first breath time will same with remainder
        if(sec%10 != 0)
        {
            dece = sec%10;//make remainder
            breathIn = dece/2;
            breathOut = dece - breathIn;

            Console.Write("Breath in ...");
            for(int i=breathIn; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nNow breath out...");
            for(int i = breathOut; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

            sec = sec - dece;
            breathIn = 4;
            breathOut = 6;
            while(sec>0)
            {
                Console.Write("\n\nBreath in ...");
                for(int i=breathIn; i>0; i--)
                {
                    sec--;
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                }
                Console.Write("\nNow breath out...");
                for(int i = breathOut; i>0; i--)
                {
                    sec--;
                    Console.Write(i);
                    Thread.Sleep(1000); 
                    Console.Write("\b \b");                  
                }
            }
    }

    public void lastMessage(int seco)
    {
        Console.WriteLine($"You have completed {seco} seconds of the {actName}");
        spinner();
    }
}