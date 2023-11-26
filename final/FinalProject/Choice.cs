class Choice
{

    private string _userInput;//for user input
    private int _userChoice;//for change string to int
    
    public int UserChoicec()
    {
        _userInput = Console.ReadLine();//asking a number
        _userChoice = int.Parse(_userInput);//change string to int

        return _userChoice;//return int
    }
}