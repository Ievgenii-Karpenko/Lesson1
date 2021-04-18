using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = false;

            if (isAlive)
            {
                Console.WriteLine("Player is alive!");
            }
            else
            {
                Console.WriteLine("Player is dead :(");
            }

            bool fullHP = true, fullAmmo = true;

            // || - логічне "або"
            // && - логічне "і"
            // == - рівність значень
            // != - не рівність значень
            // > - більше
            // < - менше
            // >= - більше дорівнює
            // <= - менше дорівнює

            if (fullHP && fullAmmo)
            {
                Console.WriteLine("Player has full HP and full ammo");
            }

            Console.WriteLine("Please enter a date");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            int currentYear = 2021;

            if (day == 8 && month == 3 && year == currentYear)
            {
                Console.WriteLine("Happy women's day");
            }
            else
            {
                Console.WriteLine("This is not March 8th");
            }

            if (year > currentYear)
            {
                Console.WriteLine("This is the future year");
            }
            else if (year < currentYear)
            {
                Console.WriteLine("This is the past year");
            }
            else if (year == currentYear)
            {
                Console.WriteLine("This is the current year");
            }

            Console.WriteLine("Please write the number of door");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: // if (choice == 1)
                    Console.WriteLine("Congratulations! You found the treasure");
                    break;
                case 2: // elseif (choice == 2)
                    Console.WriteLine("You lose! There is the enemy");
                    break;
                case 3: // elseif (choice == 3)
                case 4:
                case 5:
                    Console.WriteLine("This door is empty");
                    break;
                default:
                    Console.WriteLine("There is no such door");
                    break;
            }

            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number != 13)
            {
                Console.WriteLine("This is not unhappy number");
            }
        }
    }
}
