using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {  
        GoalManagement goalManagement = new GoalManagement();//Call the GoalManager class
        MainMenu mainMenu = new MainMenu();//Call MainMenu        
        GoalMenu goalMenu = new GoalMenu();//Call GoalMenu

        Console.Clear();  // Clear the display
        Console.Write($"\nYou have {goalManagement.GetTotalPoints()} points.\n"); 

        int number = 0;//Making number for while
        while (number != 6)
        {           
            number = mainMenu.UserChoice();// Ask for user input (1-6)
            switch (number)
            {
                case 1: // Create New Goal                  
                    Console.Clear();  // This will clear the console  
                    int goalInput = 0; // for 3 specific goal

                    while (goalInput != 4)// Ask for user input (1-3)
                    // switch case for goals menu
                    {
                        goalInput = goalMenu.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:// Simple Goal                               
                                Console.WriteLine("What is the name of your goal?  ");
                                string name = Console.ReadLine();
                                Console.WriteLine("What is a short description of your goal?  ");
                                string description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());

                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);//Call a new class
                                goalManagement.AddGoal(sGoal);//Save to list
                                goalInput = 4;//Make leave the specific goal menu
                                break;

                            case 2:// Eternal Goal                                
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                Console.WriteLine("What is a short description of it?  ");
                                description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());

                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);//Call a new class
                                goalManagement.AddGoal(eGoal);//save to list
                                goalInput = 4;//Make leave the specific goal menu
                                break;

                            case 3:// Checklist Goal                               
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                Console.WriteLine("What is a short description of it?  ");
                                description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());

                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goalManagement.AddGoal(clGoal);//save to list
                                goalInput = 4;//Make leave the specific goal menu
                                break;
                            default:
                                Console.WriteLine($"\nYou have to put a number between 1 to 3");
                                break;
                        }
                    }
                    break;

                case 2: // List Goals                
                    Console.Clear();  // This will clear the console
                    goalManagement.ListGoals();
                    Console.Write($"\nYou  have {goalManagement.GetTotalPoints()} points.\n");
                    break;

                case 3:// Save Goals                    
                    goalManagement.SaveGoals();
                    break;

                case 4:// Load Goals                   
                    Console.Clear();  // This will clear the console
                    goalManagement.LoadGoals();
                    Console.Write($"\nYou  have {goalManagement.GetTotalPoints()} points.\n");
                    break;

                case 5:// Record Event                    
                    Console.Clear();  // This will clear the console
                    goalManagement.RecordGoalEvent();
                    Console.Write($"\nYou  have {goalManagement.GetTotalPoints()} points.\n");
                    break;

                case 6:// Quite                   
                    break;

                default:
                    Console.WriteLine($"\nYou have to put a number between 1 to 6.");
                    break;
            }
        }
    }
}