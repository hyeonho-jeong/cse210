class Entry
{   
    public List<PromptGenerator> _pg = new List<PromptGenerator>();  //Make a list by PromptGenerators

    public void Display() // do display by using list
    {
        foreach (PromptGenerator pg in _pg)
        {
            pg.Display();
        }
    }
   
}