using ConsoleApp30.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание (1-30): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Задание №1");
                        Task1 task1 = new Task1(15, 20);
                        task1.Calculate();
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Задание №2");
                        Task2 task2 = new Task2(4, 13);
                        task2.Calculate();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Задание №3");
                        Task3 task3 = new Task3(6, 3);
                        task3.Calculate();
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Задание №4");
                        Task4 task4 = new Task4(7, 4);
                        task4.Calculate();
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Задание №5");
                        Task5 task5 = new Task5(2.5, 4);
                        task5.Calculate();
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Задание №6");
                        Task6 task6 = new Task6(10, 2);
                        task6.Calculate();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Задание №7");
                        Task7 task7 = new Task7(10, 2);
                        task7.Calculate();
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("Задание №8");
                        Task8 task8 = new Task8(2.0);
                        task8.Calculate();
                        Console.ReadKey();
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("Задание №9");
                        Task9 task9 = new Task9(5);
                        task9.Calculate();
                        Console.ReadKey();
                        break;

                    case "10":
                        Console.Clear();
                        Console.WriteLine("Задание №10");
                        Task10 task10 = new Task10(5);
                        task10.Calculate();
                        Console.ReadKey();
                        break;

                    case "11":
                        Console.Clear();
                        Console.WriteLine("Задание №11");
                        Task11 task11 = new Task11(2.0, 4);
                        task11.Calculate();
                        Console.ReadKey();
                        break;

                    case "12":
                        Console.Clear();
                        Console.WriteLine("Задание №12");
                        Task12 task12 = new Task12(2.0, 4);
                        task12.Calculate();
                        Console.ReadKey();
                        break;

                    case "13":
                        Console.Clear();
                        Console.WriteLine("Задание №13");
                        Task13 task13 = new Task13(2.0, 4);
                        task13.Calculate();
                        Console.ReadKey();
                        break;

                    case "14":
                        Console.Clear();
                        Console.WriteLine("Задание №14");
                        Task14 task14 = new Task14(0.5, 4);
                        task14.Calculate();
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}