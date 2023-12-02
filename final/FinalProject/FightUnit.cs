abstract class FightUnit
{
    public string name {get;set;}
    public int level {get; set;}
    public int attack {get; set;}
    public int hp {get; set;}
    public int maxHp {get; set;}
    public int exp {get; set;}
    public int maxExp {get; set;}
    public int money {get; set;}


    public bool IsDeath()//checking the fightUnit is dead 
    {
        return hp <= 0; 
    }

    public abstract void UnitInfo();

    public void Damage(FightUnit _OtherUnit)
    {   
        Console.Write(name);
        Console.Write(" gets ");
        Console.Write(_OtherUnit.attack);
        Console.WriteLine(" damage");
        Console.ReadKey();
        hp -= _OtherUnit.attack;
        Console.WriteLine("");
    }


}