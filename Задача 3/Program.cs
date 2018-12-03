using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long product = 1;
            for (int i = 0; i <= k; i++)
            {
                product *= (n - i* k);
    }
}


    