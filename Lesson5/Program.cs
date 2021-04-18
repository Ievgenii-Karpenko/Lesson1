using System;
using System.Collections.Generic;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>();
            Console.WriteLine("Please write 5 PC games");

            for (int i = 0; i < 5; i++)
            {
                string game = Console.ReadLine();
                games.Add(game);
            }

            Console.WriteLine("Please write letter");
            string letter = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                if (games[i].StartsWith(letter.ToLower()) || games[i].StartsWith(letter.ToUpper()))
                {
                    Console.WriteLine(games[i]);
                }    
            }

            // Масив даних
            //int[] ages = new int[7];
            //string[] names = new string[ages.Length];

            //Console.WriteLine("Please enter names");
            //for (int i = 0; i < ages.Length; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Please enter ages");
            //for (int i = 0; i < ages.Length; i++)
            //{
            //    ages[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine($"Name of {i} user = " + names[i]);
            //    Console.WriteLine($"Age of {i} user = " + ages[i]);
            //}

            //Список
            List<string> names = new List<string>();
            List<int> ages = new List<int>();
            int namesCount = 7;

            Console.WriteLine("Please enter names");

            for (int i = 0; i < namesCount; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine("Please enter ages:");
            for (int i = 0; i < namesCount; i++)
            {
                int age = Convert.ToInt32(Console.ReadLine());
                ages.Add(age);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Names started with \"V\"");
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].StartsWith("V"))
                {
                    names.RemoveAt(i);
                }
            }

            foreach (var name in names)
            {
                names.Remove(name);
                Console.WriteLine(name);
            }

            names.Remove("Vova");
            names.RemoveAt(3);

            names.Sort();
            Console.WriteLine("-----------------");
            Console.WriteLine("Sorted names:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Name of {i} user = " + names[i]);
            }

            Console.WriteLine("Unsorted ages:");
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }

            ages.Sort();
            ages.Reverse();

            Console.WriteLine("Sorted ages:");
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }

        }
    }
}
