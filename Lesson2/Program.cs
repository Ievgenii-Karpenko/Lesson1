using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // [тип змінної] ім"я змінної = значення
            // string name = "Ievgenii";
            // int age = 27;
            // double speed = 5.5;
            // float speed = 5.5f;
            // byte someVariable = 300;

            string name;
            Console.WriteLine("Please write your name");
            name = Console.ReadLine();
            int age;
            Console.WriteLine("Please write your age");
            age = Convert.ToInt32(Console.ReadLine());
            double speed;
            Console.WriteLine("Please write your speed");
            speed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Player name: " + name);
            Console.WriteLine("Player speed: " + speed);
            Console.WriteLine("Player age: " + age);

            int doubleSize = sizeof(double);
            Console.WriteLine("The double has " + doubleSize + " bytes");

            Console.WriteLine("Current speed is: " + speed);
            Console.WriteLine("Press Enter to speed up");
            Console.ReadLine();
            speed = speed + 10;
            speed += 10;
            Console.WriteLine("Current speed is: " + speed);

            speed -= 15; // speed = speed - 10;
            speed *= 10; // speed = speed * 10;
            speed /= 10; // speed = speed / 10;

            Console.WriteLine("Current speed is: " + speed);

            char letter = 'A';
            letter = '9';
            letter = '\t';

            int myAge = 27;
            int dadAge = 58;

            double howMuch = (double)dadAge / myAge;
            Console.WriteLine("My dad older than me in " + howMuch + " times");

            byte MaxB = 255;
            MaxB += 10;

            Console.WriteLine("The value of MaxB is: " + MaxB);
        }
    }
}
