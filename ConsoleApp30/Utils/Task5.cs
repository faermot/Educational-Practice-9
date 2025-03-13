using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task5
    {
        double A;
        int N;

        public Task5(double A, int N)
        {
            this.A = A;
            this.N = N;
        }

        public void Calculate()
        {
            double sum1 = 0;
            double sum2 = 0;
            double term = 1;

            for (int i = 0; i <= N; i++)
            {
                sum1 += term;
                term *= A;
            }

            term = 1;
            for (int i = 0; i <= N; i++)
            {
                sum2 += term * (i % 2 == 0 ? 1 : -1);
                term *= A;
            }

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
