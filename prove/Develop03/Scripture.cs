class Scripture 
{
    private string _scripture;
    private List<string> _hiddenWords;
    public int[] array = new int[30];

    public int cnt = 0;

    //initializer Array
    public void ResetArray()
    {
        while(cnt<30)
         {
            array[cnt++] = 0;
        }
    }

    public Scripture(string scripture)
    {
        _scripture = scripture;
        _hiddenWords = new List<string>();
    }

    // Make a function to display on the screen
    public void DisplayScripture()
    {
        //convert the string into an array of words
        string[] words = _scripture.Split(new char[]{' '});

        foreach(string word in words)
        {
            //check if the word is hidden
            if(_hiddenWords.Contains(word))
            {
                Console.Write(" ____ ");
            }
            else
            {
                Console.Write(word + " ");
            }
        }      
    }

    public void HideWord()
    {
        //Select a random word from the scripture text
        string[] words = _scripture.Split(new char[]{' '});

        Random rand = new Random();
        int index = rand.Next(words.Length);
     
        //Checking if the array 1 or 1
        while(array[index] == 1){
            index = rand.Next(words.Length);
        }

        array[index] =1;
        string wordToHid = words[index];

        //add the word to the list of hidden words
        _hiddenWords.Add(wordToHid);
    }

    public bool AllWordHidden()
    {
        //check if all words in the scirpture text are in the list of hidden words
        string[] words = _scripture.Split(new char[]{' '});
        return _hiddenWords.Count == words.Length;
    }  
}