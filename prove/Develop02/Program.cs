using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    { 
        //call the class"Question"
        Question NewQuestion = new Question();

        //call the class"Write" --> 5 quesitons
        Write w1 = new Write();
        Write w2 = new Write();
        Write w3 = new Write();
        Write w4 = new Write();
        Write w5 = new Write();
        
        //call the class "Numbers"
        Numbers NewNumber = new Numbers();

        //make a check number != 5
        int CheckNumber = 0;

        //Make a list from the answers.
        List<Write> questionAndAnswer = new List<Write>();

        do
        {
            //Call the member function from class "Quesiton"
            NewQuestion.questions();

            //Let people write down a number on display
            CheckNumber = NewNumber.askNumber();
            
            //Change member function to local variable about make randome number
            int randomeCheckNumber =  NewNumber.MakeRandomNumber();
          

            if(CheckNumber == 1)//write
            {
        
                if(randomeCheckNumber == 1)
                {
                    w1.question = "Who was the most intereting person I interacted with today?";
                    Console.WriteLine("Who was the most intereting person I interacted with today?");
                    w1.answer = Console.ReadLine();
                    w1.time = DateTime.Now.ToShortDateString();

                    questionAndAnswer.Add(w1);//<--adding to list
                }
                else if(randomeCheckNumber==2)
                {
                    w2.question = "What was the best part of my day?";
                    Console.WriteLine("What was the best part of my day?");
                    w2.answer = Console.ReadLine();
                    w2.time = DateTime.Now.ToShortDateString();
                   
                    questionAndAnswer.Add(w2);
                }
                else if(randomeCheckNumber == 3)
                {
                    w3.question = "How did I see the hand of the Lord in my life today?"; 
                    Console.WriteLine("How did I see the hand of the Lord in my life today?");
                    w3.answer = Console.ReadLine();
                    w3.time = DateTime.Now.ToShortDateString();

                    questionAndAnswer.Add(w3);
                }
                else if(randomeCheckNumber == 4)
                {
                    w4.question = "What was the strongest emotion I felt today?"; 
                    Console.WriteLine("What was the strongest emotion I felt today?");
                    w4.answer = Console.ReadLine();
                    w4.time = DateTime.Now.ToShortDateString();

                    questionAndAnswer.Add(w4);
                }
                else
                {
                    w5.question = "If I have one thing I could do over today, what would it be?"; 
                    Console.WriteLine("If I have one thing I could do over today, what would it be?");
                    w5.answer = Console.ReadLine();
                    w5.time = DateTime.Now.ToShortDateString();

                    questionAndAnswer.Add(w5);
                }             
            }

            else if(CheckNumber ==2)//display
            {
                foreach(Write qa1 in questionAndAnswer)
                {
                    Console.WriteLine($" - Promt:{qa1.time} {qa1.question}: {qa1.answer}");//<- write down the time, quesiotn and answer from list
                }
            }

            else if(CheckNumber ==3)//load
            {
                Console.WriteLine("What is the file name?");
                string checkFileName = Console.ReadLine();

                List<Write>questionAndAnswer3 = ReadFromFile(checkFileName);
                foreach(Write qa2 in questionAndAnswer3)
                {
                    Console.WriteLine(qa2.time);
                    Console.WriteLine(qa2.question);
                    Console.WriteLine(qa2.answer);
                }
            }

            else if(CheckNumber == 4)//save
            {
                SaveToFile(questionAndAnswer);
            }

        }while(CheckNumber != 5);
    }

        public static void  SaveToFile(List<Write>questionAndAnswer)
        {
            Console.WriteLine("What is the file name?");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(Write qa1 in questionAndAnswer)
                {
                    outputFile.WriteLine($"- Promt: {qa1.time} ,{qa1.question},:{qa1.answer}");
                }
            }
        }

        public static List<Write> ReadFromFile(string fileName)
    {
        List<Write> questionAndAnswer2 = new List<Write>();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            string[] parts = line.Split(",");

            Write newWrite = new Write();
            newWrite.time = parts[0];
            newWrite.question = parts[1];
            newWrite.answer = parts[2];    

            questionAndAnswer2.Add(newWrite);
        }

        return questionAndAnswer2;
    }
}