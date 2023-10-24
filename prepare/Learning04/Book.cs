using System;

public class Book
{
    protected string _author = "";
    protected string _titile = "";

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetTitle()
    {
        return _titile;
    }

    public void SetTitile(string title)
    {
        _titile = title;
    }
}