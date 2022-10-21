using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileProject5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y, x;
            x = -2;
            do
            {
                y = (-2.4 * Math.Pow(x, 2)) + (5 * x - 3);
                Console.WriteLine("x={0:0.00} y={1:0.00}", x, y);
                x = x + 0.5;
            }
            while (x <= 2);
            Console.ReadKey();

        }
    }
}
