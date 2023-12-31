using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int number = 0; //make member valuable for "do-while loop"
        
        Entry entry = new Entry(); //Call Entry class
        PromptGenerator promptGenerator1 = new PromptGenerator();//call Propt class        
        Journal journal = new Journal(); //call Journal class

        do{ //Display the options and return the number
            number = journal.DisplayJournal();

            switch(number)
            {
                case 1 ://write                   
                    PromptGenerator promptGenerator = new PromptGenerator();//call Propt class   
                    promptGenerator.RandomPrompt(); //print random prompt                    
                    promptGenerator.answer = Console.ReadLine(); //ask input from user                    
                    promptGenerator.time = DateTime.Now.ToShortDateString();  //Get current time                                  
                    entry._pg.Add(promptGenerator);//put prompt and answer to lsit 
                    break;
                case 2 ://display                    
                    promptGenerator1.RandomMessage();//print random messeage                    
                    entry.Display();//print the list
                    break;
                case 3 ://load
                     string fileName = journal.LoadFile(); // asking the file name
                     journal.ReadFile(fileName); // checking the file name, and if there has print it

                    break;
                case 4 ://save
                    Journal.SaveToFile(entry._pg); // save the 
                    break;
            }

        }while(number != 5);
    }

}