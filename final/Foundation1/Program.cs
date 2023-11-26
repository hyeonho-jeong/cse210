using System;

class Program
{
    static void Main(string[] args)
    {
        int lineCount = File.ReadAllLines("file.txt").Length;
        string[] lines = System.IO.File.ReadAllLines("file.txt");
        int randomLineNum;
        int indicator = 0;

        Random rnd = new Random();
        randomLineNum = rnd.Next(lineCount);

        while(lines != null)
        {
            if(indicator == randomLineNum)
            {
                Console.WriteLine(indicator);
                break;
            }
            indicator++;
        }
    }

}