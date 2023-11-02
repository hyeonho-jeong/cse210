using System.Dynamic;

class Word
{
    private bool hidden=false;
    
    private string textWord;
    
    public Word(string _textWord)
    {
        textWord = _textWord;
    }

    public string GettextWord()
    {
        return textWord;
    }

    public bool GetHidden(){
        return hidden;
    }

    public void Hide()
    {
        hidden =true;       
    }
}