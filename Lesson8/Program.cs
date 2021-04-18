using System;
using System.Diagnostics;
using System.IO;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\test\MyFile.txt";
            Console.WriteLine($"Please write a text that you want to input to the file {path}");
            string content = Console.ReadLine();

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            File.WriteAllText(path, content);

            if (File.Exists(path))
            {
                Console.WriteLine($"File {path} exists");
                File.Copy(path, @"C:\test\MyFile_Copy.txt");
                //File.Delete();
            }
            else
            {
                Console.WriteLine($"File {path} NOT exists");
            }

            string path2 = @"C:\test\innerTest";
            Directory.CreateDirectory(@"C:\test\innerTest");

            File.Move(path, path2 + @"\MyFile.txt");

            string playerPath = @"C:\test\innerTest\Player.txt";
            if (File.Exists(playerPath))
            {
                string[] playerInfo = File.ReadAllLines(playerPath);
                string name = "";
                string surname = "";
                int age = 0;

                foreach (string item in playerInfo)
                {
                    if (item.StartsWith("name=")) //name=Mark
                    {
                        name = item.Substring("name=".Length);
                    }
                    else if (item.StartsWith("surname=")) //surname=Jonson
                    {
                        surname = item.Substring("surname=".Length);
                    }
                    else if (item.StartsWith("age=")) //age=18
                    {
                        age = Convert.ToInt32(item.Substring("age=".Length));
                    }
                }

                Console.WriteLine($"Player name: {name}");
                Console.WriteLine($"Player surname: {surname}");
                Console.WriteLine($"Player age: {age}");

                Console.WriteLine("Hello World!");
            }

            string chrome = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            string site = @"https://dou.ua";
            ProcessStartInfo info = new ProcessStartInfo(chrome, site);
            Process.Start(info);

            try
            {
                string directoryPath = @"C:\test\Classwork";
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Classwork_1, Classwork_2, ... Classwork_10
                // @"string chrome = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";"
                for (int i = 0; i < 10; i++)
                {
                    File.WriteAllText(directoryPath + @$"\Classwork_{i + 1}.txt",
                        @"string chrome = @""C:\Program Files(x86)\Google\Chrome\Application\chrome.exe"";");
                }
            }
            catch(DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("There is no such folder ^(");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Створити програму, яка створює на диску С або D папку Homework і всередині цієї папки створює 
            // 7 окремих файлів з назвами HomeWork_1.txt, HomeWork_2.txt .. HomeWork_7.txt
            // Текст цих файлів: "This is the text of HomeWork_1", "This is the text of HomeWork_2"
            // Створення файлів має бути в циклі.
            // Не забути це все заключити в блоки try/catch з обробкою можливих помилок

        }
    }
}
