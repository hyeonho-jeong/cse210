class Scripture 
{
    private string _scripture;//Make a valuable 
    private List<Word> words = new List<Word>();//Make a list to put each word from scripture


    public Scripture(string scripture) // Make a each list for each word
    {
        _scripture = scripture;
        string[] eachWord = _scripture.Split(new char[]{' '});

        foreach(string sepWord in eachWord)
        {
            Word newWord = new Word(sepWord);
            words.Add(newWord);
        }
    }

    
    public void DisplayScripture()// Make a function to display on the screen
    {
        foreach(Word word in words)
        {
            if(word.GetHidden())
            {
                Console.Write(" ____ ");
            }
            else
            {
                Console.Write(word.GettextWord() + " ");
            }
        }      
    }

    public void HideWord()
    {
        Random rand = new Random();
        int index = rand.Next(words.Count());

        while(words[index].GetHidden())//Checking it is already hidden or not
        {
            index = rand.Next(words.Count);
        }
        words[index].Hide();
    }

    public bool AllWordHidden()
    {
        foreach(Word word in words)
        {
            if(!word.GetHidden())
            {
                return false;
            }
        }
        return true;
    }  
}