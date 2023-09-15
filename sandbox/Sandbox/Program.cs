using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello sandbox World!!!");
        Console.WriteLine("this is in C#");

        int number = 5;
        number = 8;
        number =number+3;

        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();//input 이라 보면 됨
        Console.WriteLine("Your color is" + color);//print 라 보면 됨
    //Console.WriteLine($"Your color is {color}"); 위의 값과 같음
    }
}