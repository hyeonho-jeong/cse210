using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>();

        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        //if user picks option to add a new entry
        //1. pick a random prompt from list above
        //2.display random rompt
        //3.save entry from user
        //4.create entry object


        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToShortDateString();
       

        Journal journal = new Journal();
        journal.JOurnalName = "";
        journal.Entries = new List<Entry>();
        journal.Entries.Add(entry);
        
        //save journal to file system

    }
}