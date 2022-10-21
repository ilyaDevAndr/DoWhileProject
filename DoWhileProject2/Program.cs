using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y, x;
            x = -2;
            do
            {
                y = ((x * 2) + 5) / (2 * x);
                Console.WriteLine("x={0:0.00} y={1:0.000}", x, y);
                x = x + 0.5;
            }
            while (x <= 1);
            Console.ReadKey();

        }
    }
}
