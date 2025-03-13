using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task8
    {
        double A;

        public Task8(double A)
        {
            this.A = A;
        }

        public void Calculate()
        {
            double sum = 0;
            int N = 1;
            while (sum <= A)
            {
                sum += 1.0 / N;
                N++;
            }
            Console.WriteLine($"Наименьшее N: {N - 1}, Сумма: {sum}");
        }
    }
}
