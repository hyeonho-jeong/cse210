using System;
using System.IO;
using System.Globalization;
using System.Security.Cryptography;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{ 
    static void Main(string[] args)
    {   
        Welcome newWelcome = new Welcome(); // call a welcom class for use input 
        Battle newBattle = new Battle();//call a battle class for list<User>
        User newUser = new User(); // call a user class and get a name from user
        Choice newChoice = new Choice();//call a choice class
        TownMenu newTownMenu = new TownMenu();//call a townmenu class

        string AskUserName = newWelcome.startMessage();//Get a name from user
        
        newUser.name = AskUserName;
        newUser.level = 1;
        newUser.attack = 10;
        newUser.hp = 50;
        newUser.maxHp = 100;
        newUser.exp = 0;
        newUser.maxExp = 100;
        newUser.money = 0;

        newBattle.userInformation.Add(newUser);     
        int choice = 0;//give a number for start while loop

        MainMenu newMainMenu = new MainMenu();//call a MainMenu class
        while(choice != 3)
        {
            newUser.UnitInfo();//showing user information
            newMainMenu.DisplayMenu();//showing the main menu options
            choice = newChoice.UserChoicec();//asking pick a number

            switch(choice)
            {
                case 1:    
                    newTownMenu.DisplayMenu();
                    int choice1 = newChoice.UserChoicec();//asking pick a number
                    switch(choice1)
                    {
                        case 1:
                            newUser.Healing();
                            break;
                        case 2:
                            newUser.upgradeAttack();
                            break;
                        case 3:
                            break;
                    }

                    break;
                case 2:
                    newBattle.fight();
                    break;
                case 3:
                    break;
            }
        }       
    }
}