using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y, x;
            x = 0;
            do
            {
                y = 3 * Math.Pow(x, 2) - 1.8 * x;
                Console.WriteLine("x={0:0.00} y={1:0.000}", x, y);
                x = x + 0.5;
            }
            while (x <= 5);
            Console.ReadKey();

        }
    }
}
