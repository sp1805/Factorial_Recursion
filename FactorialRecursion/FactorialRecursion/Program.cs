using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long res = 1;
            if (n >= 0)
            {
                res = Factorial(n);
                Console.WriteLine(res);
            }
        }

        public static long Factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
