using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //SayHello();
            //string name = "Ivan";
            //HelloFriend(name);

            //List<string> names = new List<string>();
            //names.Add("Ivan");
            //names.Add("Volodymyr");
            //names.Add("Stepan");
            //names.Add("Vasyl");
            //names.Add("Ievgenii");
            //names.Add("Vladyslaw");
            //ShowNames(names);

            Console.WriteLine("Please enter 2 numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(@"Please choose the action: * \ - +");
            string action = Console.ReadLine();
            int result = 0;

            if(action == "*")
            {
                result = Mult(num1,num2);
            }
            else if(action == "+")
            {
                result = Sum(num1, num2);
            }
            else if (action == "-")
            {
                result = Diff(num1, num2);
            }
            else if (action == @"\")
            {
                result = Devide(num1, num2);
            }
            else
            {
                Console.WriteLine("There is no such action");
            }
            Console.WriteLine("Result is: " + result);

            //int res1;
            //int res2;

            //SumAndDiff(num1, num2, out res1, out res2);
            //Console.WriteLine($"The sum of {num1} and {num2} is {res1}");
            //Console.WriteLine($"The diff of {num1} and {num2} is {res2}");

            //int summa = Sum(num1, num2);
            //Console.WriteLine($"The sum of {num1} and {num2} is {summa}");

            //int diff = Diff(num1, num2);
            //Console.WriteLine($"The diff of {num1} and {num2} is {diff}");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Factorial of {i} is: " + Factorial(i));
            //}

            //int num = 10;
            //Add5(ref num); // тут передалась копія 10
            //Console.WriteLine("Result: " + num);



            Console.ReadKey();
        }

        static void Add5(ref int number)
        {
            number = number + 5;
            Console.WriteLine("Result inside method: " + number);
        }

        static void SumAndDiff(int number1, int number2, out int sumResult, out int diffResult)
        {
            sumResult = number1 + number2;
            diffResult = number1 - number2;
        }

        // 1 1 2 6 24 ...
        static int Factorial(int pos)
        {
            if (pos == 0)
                return 1;

            if (pos == 1)
                return 1;

            return pos * Factorial(pos - 1);
        }

        static int Sum(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        static int Diff(int number1, int number2)
        {
            number1 = 10;
            int result = number1 - number2;
            return result;
        }

        static int Mult(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
        static int Devide(int number1, int number2)
        {
            if (number2 == 0)
                throw new Exception("You cannot devide on zero");

            int result = number1 / number2;
            return result;
        }

        static void SayHello()
        {
            Console.WriteLine("Hello 1");
            Console.WriteLine("Hello 2");
        }

        static void HelloFriend(string friendName)
        {
            Console.WriteLine("Hello " + friendName);
        }

        static void ShowNames(List<string> names)
        {
            names.Sort();
            names.RemoveAt(0);
            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
            }
        }
    }
}
