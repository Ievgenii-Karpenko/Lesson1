using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

// Створити 3 методи які в циклі будуть 10 разів виводити на екран $"Task*номер_таска* = {i}"
// Кожен метод має виводити на екран інформацію різним кольором - Console.ForegroundColor = ConsoleColor.*колір,який хочемо*
// У методі Меін створити 3 таски і передати цим таска ці три методи відповідно
// В кінці Меін методу чекаємо завершення тасок (Task.WaitAll(t1,t2,t3);)


namespace Lesson12
{
    class Program
    {
        //static object a = new object();

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello World!");
            //await MakeTea();
            //await PrepareFood();
            var sw = new Stopwatch();
            sw.Start();

            Task t1 = Task.Run(MakeTea);
            Task t2 = Task.Run(PrepareFood);

            List<Task> taskList = new List<Task>();
            taskList.Add(PrepareFood());
            taskList.Add(MakeTea());

            Console.WriteLine("Метод меін закінчився");

            ////await Task.WhenAll(taskList);
            //await t1;
            //await t2;
            sw.Stop();
            Console.WriteLine($"Минуло {sw.ElapsedMilliseconds} мілісекунд");

            //for (int i = 0; i < 10; i++)
            //{
            //    // set color
            //    // display info
            //}
        }

        static async Task MakeTea()
        {
            Console.WriteLine("Включили чайник");
            await Task.Delay(4000);
            Console.WriteLine("Чайник закипів");
        }

        static async Task PrepareFood()
        {
            Console.WriteLine("Гріємо їжу");
            await Task.Delay(7000);
            Console.WriteLine("Їжа розігрілась");
        }

        static async Task Task1()
        {
            //lock (a)
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TASK 1");
            }
        }

        static int Summa(int a, int b)
        {
            return a + b;
        }
    }
}
