using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task7
    {
        int N, M;

        public Task7(int N, int M)
        {
            this.N = N;
            this.M = M;
        }

        public void Calculate()
        {
            int K = 1;
            while (3 * K < N)
            {
                K++;
            }
            K--;
            Console.WriteLine($"Наибольшее K: {K}, 3K = {3 * K}");
        }
    }
}
