using System;

namespace Lesson1Average
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int num1;
            int num2;
            int num3;
            double average;

            Console.Write("Enter the first number: ");
            userInput = Console.ReadLine();
            num1 = int.Parse(userInput);

            Console.Write("Enter the second number: ");
            userInput = Console.ReadLine();
            num2 = int.Parse(userInput);

            Console.Write("Enter the third number: ");
            userInput = Console.ReadLine();
            num3 = int.Parse(userInput);

            average = (num1 + num2 + num3) / 3.0D;
            Console.WriteLine("Average of {0}, {1}, and {2} is {3}", num1, num2, num3, average);

            Console.ReadKey(true);
        }
    }
}
