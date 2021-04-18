using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;

            while (counter < 10) // = true
            {
                Console.WriteLine("Hello World! " + counter);
                counter++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
            }

            counter = 0;

            do
            {
                Console.WriteLine("Hello World! " + counter);
                counter++;
            }
            while (counter < 10);

            //collection = 1,2,3,4,5,5

            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            string choice = "";
            string treasureNumber = new Random().Next(1, 5).ToString();

            while (choice != "exit")
            {
                Console.WriteLine("Please write the number of door");
                Console.WriteLine("If you want to exit write \"exit\"");
                choice = Console.ReadLine();

                if (choice == treasureNumber)
                {
                    Console.WriteLine("Congratulations! You found the treasure");
                    break;
                }

                switch (choice)
                {
                    case "1": // if (choice == 1)
                        Console.WriteLine("Congratulations! You found the treasure");
                        break;
                    case "2": // elseif (choice == 2)
                        Console.WriteLine("You lose! There is the enemy");
                        break;
                    case "3": // elseif (choice == 3)
                    case "4":
                    case "5":
                        Console.WriteLine("This door is empty");
                        break;
                    default:
                        Console.WriteLine("There is no such door");
                        break;
                }

                if (choice == "1")
                    break;

                Console.WriteLine("--------------------------------");
                Console.WriteLine();
            }


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i}x{j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
