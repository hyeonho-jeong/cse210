using System.IO;

class Monster : FightUnit
{
    private string fileName;
    private int lineCount;

    private int _randomNumber;  //This is for random number
    User newUser = new User();

    public Monster()
    {
        
    }

    public string LoadFile() // check the file name depends on user's level.
    {
        if(newUser.level < 10)
            fileName = "normal.txt";
        else if(newUser.level >= 10 && newUser.level < 15)
            fileName = "middle.txt";
        else
            fileName = "hard.txt";
        return fileName;
    }


    public void ReadFile(string fileName)// printing the file 
    {
        lineCount = File.ReadAllLines(fileName).Length;
        string[] lines = System.IO.File.ReadAllLines(fileName);
        Random newrandom = new Random();
        int randomeLineNum = newrandom.Next(lineCount);

        string theLine = lines[randomeLineNum];
                    string[] parts = theLine.Split(",");

                    name = parts[0];
                    string monsterlevel = parts[1];
                        level = int.Parse(monsterlevel);
                    string monsterattack = parts[2];
                        attack = int.Parse(monsterattack);
                    string monsterhp = parts[3];
                        hp = int.Parse(monsterhp);
                    string monstermaxHp = parts[4];
                        maxHp = int.Parse(monstermaxHp);
                    string monsterexp = parts[5];
                        exp = int.Parse(monsterexp);
                    string monstermoney = parts[6];
                        money = int.Parse(monstermoney);    
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
}