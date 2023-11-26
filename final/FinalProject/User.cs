class User : FightUnit
{   
    public User()
    {
        
    }


    public int userLevel()
    {
        return this.level;
    }

    public int AttackUp(int addAttack)
    {
        return attack += addAttack;
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
        Console.WriteLine($"  Information of the {name}");
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
                    Console.WriteLine("HP is already full.");
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
            Console.WriteLine("Money is scarce.");
        }
        else
        {
            this.attack += 3;
            this.money -= 10;
        }
    }

}