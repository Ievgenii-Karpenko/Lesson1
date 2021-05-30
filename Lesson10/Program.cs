using System;
using System.Collections.Generic;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "John";
            player1.HP = -100;
            player1.Weapon = new List<string>();
            player1.Weapon.Add("Gun");
            player1.Weapon.Add("Assault Rifle");

            //Console.WriteLine("Is sniper: " + player1.IsSniper);

            player1.ShowInfo();

            //player1.DecreseHP(40);
            //player1.DecreseHP(40);
            //player1.DecreseHP(40);

            //player1._hp = 515;
            player1.HP = 2500;

            player1.ShowInfo();
            player1.SaveToPC();

            Console.WriteLine("-----------------------------");

            Player Albert = new Sniper();
            Albert.Name = "Albert";
            Albert.HP = 70;
            Albert.Weapon = new List<string>();
            Albert.Weapon.Add("Gun");
            Albert.Weapon.Add("Assault Rifle");
            Albert.Weapon.Add("AWP");
            //Albert.ZoomLevel = 2;

            //Albert._name = "adasd";

            Albert.ShowInfo();

            Player p1 = new Player();
            p1.VirtulaMethod();

            Console.WriteLine("-----------------------------");

            Sniper s1 = new Sniper();
            s1.VirtulaMethod();

            Console.WriteLine("-----------------------------");

            Player s2 = new Sniper();
            s2.VirtulaMethod();

            //Player p1 = new Player("Donald", 89);
            //p1.ShowInfo();

            //Console.WriteLine("-----------------------------");

            //Sniper s1 = new Sniper("Habib", 90);
            //s1.ShowInfo();
        }
    }
}
