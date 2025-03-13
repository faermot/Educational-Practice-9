using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task12
    {
        double X;
        int N;

        public Task12(double X, int N)
        {
            this.X = X;
            this.N = N;
        }

        public void Calculate()
        {
            double sum = 0;
            double term = X;
            for (int i = 1; i <= N; i++)
            {
                sum += term * (i % 2 == 1 ? 1 : -1);
                term *= X * X / (2 * i + 1);
            }
            Console.WriteLine(sum);
        }
    }
}
