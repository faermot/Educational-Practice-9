using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task3
    {
        double A;
        int N;

        public Task3(double A, int N)
        {
            this.A = A;
            this.N = N;
        }

        public void Calculate()
        {
            double result = 1;
            for (int i = 1; i <= N; i++)
            {
                result *= A;
            }
            Console.WriteLine($"{A} в степени {N} = {result}");
        }
    }
}
