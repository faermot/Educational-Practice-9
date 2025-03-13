using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task4
    {
        double A;
        int N;

        public Task4(double A, int N)
        {
            this.A = A;
            this.N = N;
        }

        public void Calculate()
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{A} в степени {i} = {Math.Pow(A, i)}");
            }
        }
    }
}
