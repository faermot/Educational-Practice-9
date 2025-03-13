using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task9
    {
        int N;

        public Task9(int N)
        {
            this.N = N;
        }

        public void Calculate()
        {
            double product = 1;
            for (int i = 1; i <= N; i++)
            {
                product *= i;
            }
            Console.WriteLine($"Произведение от 1 до {N} = {product}");
        }
    }
}
