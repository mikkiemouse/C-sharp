using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double  x, sum;
            sum = 1;
            n = InputValue("N");
            x = InputValue("x");
            for (i = 2; i <= 2 * n; i += 2)
            {
                sum += Math.Pow(x, n) / functions.factorial(n);
            }
            Console.WriteLine("The amount of N elements {0}", sum);
        }

        private static int InputValue(string name)
        {
            int n;
            Console.WriteLine("Enter {0}", name);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    return n;
                }
                Console.WriteLine("Incorrect vlue, please try again");
            }
        }
    }
}
