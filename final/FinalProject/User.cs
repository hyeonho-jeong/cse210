class User : FightUnit
{   
    public User()
    {
        
    }


    public int userLevel()
    {
        return this.level;
    }

   
    public bool checkHp()
    {
        if(this.hp >= this.maxHp)
            return true;
        else
            return false;
    }

    public int healHp()
    {
        this.hp = this.maxHp;

        return this.hp;
    }

    public override void UnitInfo()
    {    
        Console.WriteLine("-----------------------");
        Console.WriteLine($"  Name: {name}");
        Console.WriteLine($"  Level : {this.level}");
        Console.WriteLine($"  Attack : {this.attack}");
        Console.WriteLine($"  HP : {this.hp} / {this.maxHp}");
        Console.WriteLine($"  exp : {this.exp}");
        Console.WriteLine($"  money : {this.money}");
        Console.WriteLine("-----------------------");
    }

    public void Healing()
    {
        if(checkHp() == true)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("HP is already full.");
                    Console.WriteLine("----------------------");
                }
                else
                {
                    healHp();//heal the user's hp
                }
    }

    public void upgradeAttack()
    {
        if(this.money <10)
        {
            Console.WriteLine("Money is scarce. \nYou need at least 10 money to upgrade your attack power.");
        }
        else
        {
            Console.WriteLine("Use 10 money to increase your attack power by 5.");
            this.attack += 5;
            this.money -= 10;
        }
        Console.ReadKey();
        Console.Clear();
    }


    public void upgradeMaxHP()
    {
        if(this.money <10)
        {
            Console.WriteLine("Money is scarce. \nYou need at least 10 money to upgrade your Max HP.");
        }
        else
        {
            Console.WriteLine("Use 10 money to increase your max HP by 10.");
            this.maxExp += 10;
            this.money -= 10;
        }
        Console.ReadKey();
        Console.Clear();
    }

}