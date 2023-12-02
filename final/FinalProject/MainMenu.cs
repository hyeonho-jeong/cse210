class MainMenu : Menu
{

    private string menu =$@"
     Please select one of the following options:
      1. Move to the village.
      2. Do a battle.
      3. Finished the game.
    ";

    public override void DisplayMenu()
    {
        Console.WriteLine(menu);
    }

}