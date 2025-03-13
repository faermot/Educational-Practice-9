using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task11
    {
        double X;
        int N;

        public Task11(double X, int N)
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
                term *= X / i;
                sum += term;
            }
            Console.WriteLine(sum);
        }
    }
}
