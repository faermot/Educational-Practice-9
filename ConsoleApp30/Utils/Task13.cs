using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task13
    {
        double X;
        int N;

        public Task13(double X, int N)
        {
            this.X = X;
            this.N = N;
        }

        public void Calculate()
        {
            double sum = 1;
            double term = 1;
            for (int i = 1; i <= N; i++)
            {
                term *= -X * X / (2 * i);
                sum += term;
            }
            Console.WriteLine(sum);
        }
    }
}
