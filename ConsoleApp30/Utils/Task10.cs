using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task10
    {
        int N;

        public Task10(int N)
        {
            this.N = N;
        }

        public void Calculate()
        {
            double product = 1;
            for (int i = 2; i <= N; i++)
            {
                product *= 1.0 / i;
            }
            Console.WriteLine($"Произведение от 1/2 до 1/{N} = {product}");
        }
    }
}
