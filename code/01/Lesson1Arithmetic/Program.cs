using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3 + 2 * 5;
            int b = (3 + 2) * 5;
            int c = 10 % 3;
            int d = 2 - 8;
            int e = 10 / 4;
            float f = 10 / 4;
            float g = 10.0F / 4F;
            float h = 10.0F / 4.0F;

            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
            Console.WriteLine("c={0}", c);
            Console.WriteLine("d={0}", d);
            Console.WriteLine("e={0}", e);
            Console.WriteLine("f={0}", f);
            Console.WriteLine("g={0}", g);
            Console.WriteLine("h={0}", h);

            Console.ReadKey(true);
        }
    }
}
