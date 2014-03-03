using System;

namespace Lesson3Five
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string input;

            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            x = int.Parse(input);
                            
            if (x > 5)
            {
                Console.WriteLine("Greater than 5");
            }
            else if (x < 5)
            {
                Console.WriteLine("Less than 5");
            }
            else
            {
                Console.WriteLine("Equals to 5");
            } 
        }
    }
}
