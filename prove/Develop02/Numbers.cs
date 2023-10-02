class Numbers
{
     int number;
     int RandomNumber;

    //Get a number from input
    public int askNumber()
    {
        Console.Write("What would you like to do?");
        string score = Console.ReadLine();
        int number = int.Parse(score);

        return number;
    }

    //Make a random number from 1 to 5
    public int MakeRandomNumber()
    { 
        Random randomGenerator = new Random();
        RandomNumber = randomGenerator.Next(1,6);

        return RandomNumber;
    }
     


}