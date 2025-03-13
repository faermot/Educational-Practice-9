using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task2
    {
        int a, b, count;

        public Task2(int a, int b)
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
            Console.WriteLine("Все целые числа в порядке убывания: ");
            for (int i = b - 1; i >= a + 1; i--)
            {
                Console.Write($"{i} ");
                count++;
            }
            Console.WriteLine($"\nКоличество чисел: {count}");
        }
    }
}
