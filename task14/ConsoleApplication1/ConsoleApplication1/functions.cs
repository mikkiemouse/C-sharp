using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class functions
    {
         public static int factorial(int a)
        {
            int i;
            int s = 1;
            for (i = 1; i <= a; i++)
            {
                s = s * i;
            }
            return s;
    }
}
}
