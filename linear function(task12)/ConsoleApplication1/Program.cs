using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1, V2, t1, t2;
            
            V1 = InputParametr("V1");
            t1 = InputParametr("t1"); 
            V2 = InputParametr("V2");
            t2 = InputParametr("t2");
            double sumv = V1 + V2;
            double sumt = (V1*t1 + V2*t2)/2*sumv;

            Console.WriteLine("New Volume = {0} New Temperature {1}", sumv,sumt) ;
        }

        private static double InputParametr(string name)
        {
            double V1,V2,t1,t2;
            Console.WriteLine("Enter {0}", name);
            V1 = double.Parse(Console.ReadLine());
            return V1;
        }
    }
}
