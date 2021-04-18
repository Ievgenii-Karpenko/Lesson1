using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Please enter 2 numbers");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("We are inside finally");
            }

            Console.WriteLine(@"Please choose the action: * \ - +");
            string action = Console.ReadLine();
            double result = 0;

            if (action == "*")
            {
                result = Mult(num1, num2);
            }
            else if (action == "+")
            {
                result = Sum(num1, num2);
            }
            else if (action == "-")
            {
                result = Diff(num1, num2);
            }
            else if (action == @"\")
            {
                try
                {
                    result = Divide(num1, num2);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("There is some exception");
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("There is no such action");
            }
            Console.WriteLine("Result is: " + result);

            Console.ReadKey();
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
        static double Divide(int number1, int number2)
        {
            if (number2 == 0)
                throw new Exception("You cannot divide by zero");

            double result = (double)number1 / number2;
            return result;
        }
    }
}
