using System.Reflection.Metadata.Ecma335;

class Welcome
{
    private string userName;

    private string welcomeMessage = "Welcome to Text RPG game!";
    private string askUserName = "Please type your name :";

    public string startMessage()
    {
        Console.WriteLine($"{askUserName}");
        userName = Console.ReadLine();
        Console.WriteLine($"{welcomeMessage} {userName}!");
    
        return userName;
    } 
}