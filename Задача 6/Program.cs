using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long product = 1;
            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine(n*(n-k)*(n-2*k)*(n-k*k));
                product *= (n - i * k);
            }
        }
    }
}



