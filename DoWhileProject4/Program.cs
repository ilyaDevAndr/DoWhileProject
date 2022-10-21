using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileProject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y, x;
            x = 0.5;
            do
            {
                y = (6 * Math.Pow(x, 2) - 1) / (5 * x - 2);
                Console.WriteLine("x={0:0.00} y={1:0.00}", x, y);
                x = x + 0.2;
            }
            while (x <= 3);
            Console.ReadKey();

        }
    }
}
