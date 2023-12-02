using System.ComponentModel;

class Battle
{
    User newUser = new User();
    Monster newMonster = new Monster();

    public List<User>userInformation = new List<User>();//Make a list with User class

    public void SummonMonster()
    {
        string file = newMonster.LoadFile();
        newMonster.ReadFile(file);
        newMonster.UnitInfo();
        foreach(User uif in userInformation)
            {
                newUser.name = uif.name; 
                newUser.level = uif.level;
                newUser.attack = uif.attack;
                newUser.hp = uif.hp;
                newUser.maxHp = uif.maxHp;
                newUser.exp = uif.exp;
                newUser.maxExp = uif.maxExp;
                newUser.money = uif.money;
                ListDisplay();
            }
    }

    public void fight()
    {
        SummonMonster();

        while(false == newMonster.IsDeath() && false == newUser.IsDeath())
        {
            Console.Clear();
            newUser.UnitInfo();
            newMonster.UnitInfo();
            
            newMonster.Damage(newUser);        
            if(false == newMonster.IsDeath())
            {
                newUser.Damage(newMonster);
            }
            
                   
        }

        Console.WriteLine("The battle is over.");
         foreach(User uif in userInformation)
            {
                newUser.name = uif.name; 
                uif.level = newUser.level;
                uif.attack = newUser.attack;
                uif.hp = newUser.hp;
                uif.maxHp = newUser.maxHp;
                uif.exp = newUser.exp;
                uif.maxExp = newUser.maxExp;
                uif.money = newUser.money;
                ListDisplay();
            }
        if(true == newMonster.IsDeath())
        {
            Console.WriteLine($"It's a {newUser.name}'s victory.");
            //newUser.Upgrade(newMonster);
            foreach(User uif in userInformation)
            {
                if(uif.exp+newMonster.exp < uif.maxExp)
                    uif.exp +=newMonster.exp;
                else
                {
                    uif.exp = 0;
                    uif.maxExp += 20;
                    uif.level +=1;
                    uif.maxExp += 10;
                    uif.attack += 2;
                }

                uif.money += newMonster.money;
            }
        }
        else
        {
            Console.WriteLine($"It's a {newUser.name}'s defeat.\n You have to go to the village and recover your hp.");

        }
        Console.ReadKey();
        Console.Clear();

        return;
    } 

    public void ListDisplay()
    {
        foreach(User uif in userInformation)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"  Name: {uif.name}");
            Console.WriteLine($"  Level : {uif.level}");
            Console.WriteLine($"  Attack : {uif.attack}");
            Console.WriteLine($"  HP : {uif.hp} / {uif.maxHp}");
            Console.WriteLine($"  exp : {uif.exp}");
            Console.WriteLine($"  money : {uif.money}");
            Console.WriteLine("-----------------------");
            Console.ReadLine();
            Console.Clear();
        }
                
    }
        

    public void Display() // do display by using list
    {
        foreach (User userinfor in userInformation)
        {
            userinfor.UnitInfo();
        }
    }
}