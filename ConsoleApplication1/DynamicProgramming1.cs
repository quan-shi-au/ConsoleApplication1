using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DynamicProgramming1
    {
        public static int fibDynamic(int n)
        {
            int[] f = new int[n + 1];

            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <=n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }

        public static int fib(int n)
        {
            if (n <= 1)
                return n;

            return fib(n - 1) + fib(n - 2);

        }

        static void Main1(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss fff"));

            Console.WriteLine($"{fib(10)}");

            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss fff"));

            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss fff"));

            Console.WriteLine($"{fibDynamic(10)}");

            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss fff"));
            Console.Read();
        }
    }
}
