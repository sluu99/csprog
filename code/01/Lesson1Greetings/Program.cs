using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Greetings, {0}!", name);

            Console.ReadKey(true);
        }
    }
}
