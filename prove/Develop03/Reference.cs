class Reference
{
    private string _book;
    private string _chapter;
    private string _verse1;
    private string _verse2;

    public Reference()//let save the refernce in scripture
    {

    }

    public string Getbook()
    {
        return _book;
    }

     public string Getchapter()
    {
        return _chapter;
    }

     public string Getverse1()
    {
        return _verse1;
    }

    public string Getverse2()
    {
        return _verse2;
    }


    //Make two constructor. Frist is with verse 2, the other is without verse 2.
    public Reference(string book, string chapter, string verse1)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = verse1;
    }

    public Reference(string book, string chapter, string verse1, string verse2)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = verse1;
        _verse2 = verse2;
    }

    // Make a function to display on the screen
    public void GetRenderedText()
    {
        Console.WriteLine($"{_book} {_chapter}:{ _verse1}-{_verse2} ");
    }
}


