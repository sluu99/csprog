using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            int number = 18;

            Console.WriteLine("My name is {0} and my favorite number is {1}", name, number);
            Console.ReadKey(true);
        }
    }
}
