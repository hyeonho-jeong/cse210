class TownMenu : Menu
{

    private new string menu =$@"
     Please select one of the following options:
      1. Restore HP.
      2. Increases attack power.
      3. Increase the max HP.
      4. Return to the main menu.
    ";

    public override void DisplayMenu()
    {
        Console.WriteLine(menu);
    }  

}