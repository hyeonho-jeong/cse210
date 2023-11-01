using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //make member valuable for "do-while loop".
        int number = 0;

        //Call the breathing activity class
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity");

        //Call the Listing activity class
        ListingActivity listingActivity = new ListingActivity("Listing activity");

        //Call the Reflecting activity class
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting activity");

        //Call the self esteem activity class
        SelfEsteemActivity selfEsteemActivity = new SelfEsteemActivity("Self esteeming activity");

        do{

            Console.WriteLine("Menu Option: \n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Start self esteeming activity \n5. Quit\n Select a choice from the menu: ");
            string numbre = Console.ReadLine();
            number = int.Parse(numbre);
            Console.Clear();


            //do switch statement for the case 1~3
            switch(number)
            {
                case 1: // breathing
                    breathingActivity.startingMessage(); // print the name of the activity
                    breathingActivity.discriptionMessage();//print the discription of the activity
                    int sec =  breathingActivity.countDown();//asking the seconds
                    Console.Clear();

                    Console.WriteLine("Get ready...");
                    breathingActivity.spinner();//make a spinner

                    breathingActivity.breathTime(sec);// Do the activity

                    breathingActivity.endingMessage(sec);//print end message
                    //breathingActivity.lastMessage(sec);
                    Console.Clear();

                    break;

                case 2: // reflecting
                    reflectingActivity.startingMessage();// print the name of the activity
                    reflectingActivity.discriptionMessage();//print the discription of the activity
                    int sec2 = reflectingActivity.countDown();//asking the seconds
                    Console.Clear();

                    Console.WriteLine("Get ready...");
                    reflectingActivity.spinner();//make a spinner
                    reflectingActivity.Randomprompt();//print a random prompt 
                    reflectingActivity.questions(sec2);
                    
                    reflectingActivity.endingMessage(sec2);//print end message
                    //reflectingActivity.lastMessage(sec2);
                    Console.Clear();
                    
                    break;
                case 3: // listing
                    listingActivity.startingMessage();// print the name of the activity
                    listingActivity.discriptionMessage();//print the discription of the activity
                    int sec3 = listingActivity.countDown();//asking the seconds
                    Console.Clear();

                    Console.WriteLine("Get ready...");
                    listingActivity.spinner();//make a spinner
                    listingActivity.Randomprompt();//print a random prompt 
                    listingActivity.answer(sec3);
                    
                    listingActivity.endingMessage(sec3);//print end message
                    //listingActivity.lastMessage(sec3);
                    Console.Clear();
                    break;
                case 4 :// self esteeming
                    selfEsteemActivity.startingMessage();//print the name of the activity
                    selfEsteemActivity.discriptionMessage();//print the discription of the activity
                    int sec4 = selfEsteemActivity.countDown();//asking the seconds
                    Console.Clear();
                    
                    Console.WriteLine("Get ready...");
                    selfEsteemActivity.spinner();//make a spinner
                    selfEsteemActivity.Randomprompt(sec4);//print a random prompt

                    selfEsteemActivity.endingMessage(sec4);
                    Console.Clear();
                    break;
            }
        }while(number != 5);
          
    }

}