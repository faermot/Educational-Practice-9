using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task1
    {
        int a, b, count;

        public Task1(int a, int b)
        {
            if (a < b)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                Console.WriteLine("В конструктор переданы неверные параметры!");
            }
        }

        public void Calculate()
        {
            Console.WriteLine("Все целые числа в порядке возрастания: ");
            for (int i = a; i <= b; i++)
            {
                Console.Write($"{i} ");
                count++;
            }
            Console.WriteLine($"\nКоличество чисел: {count}");
        }
    }
}
