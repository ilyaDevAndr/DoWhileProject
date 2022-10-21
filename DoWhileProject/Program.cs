using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, ost;
            a = 0;
            do
            {
                ost = a % 10;
                Console.Write(ost);
                a = a / 10;
            } while (a > 0);
            Console.ReadKey();
        }
    }
}
