class MainMenu : Menu
{

    private string menu =$@"
     Please select one of the following options:
      1. Move to the village.
      2. Do a battle.
      3. Return to the main screen.
    ";

    public override void DisplayMenu()
    {
        Console.WriteLine(menu);
    }

}