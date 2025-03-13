using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30.Utils
{
    public class Task6
    {
        int N, M;

        public Task6(int N, int M)
        {
            this.N = N;
            this.M = M;
        }

        public void Calculate()
        {
            int K = 1;
            while (3 * K <= N)
            {
                K++;
            }
            Console.WriteLine($"Наименьшее K: {K}, 3K = {3 * K}");
        }
    }
}
