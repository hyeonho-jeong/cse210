class Journal
{       
    private int num;  //This is for checking optionnumber

    public int DisplayJournal()//funciton for option print
    {
        Console.WriteLine("Please select one of the following choice \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit ");
        string score = Console.ReadLine();
        num = int.Parse(score);

        return num;
    }

    public string LoadFile() // asking the file name to user
    {
        Console.WriteLine("What is the file name?");
        string checkFileName = Console.ReadLine();

        return checkFileName;
    }

    public void ReadFile(string fileName)// printing the file 
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Console.WriteLine(parts[0]);
            Console.WriteLine(parts[1]);
            Console.WriteLine(parts[2]);
          
        }
    }

    public static void SaveToFile(List<PromptGenerator>_pg)
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(PromptGenerator pg in _pg)
            {
                    outputFile.WriteLine($"Here is your journal - Promt: {pg.time} ,{pg.prompt},:{pg.answer}");
            }
        }

    }
}