using System;

namespace Lesson1AddTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int sum;
            string userInput;

            Console.Write("Enter the first number: ");
            userInput = Console.ReadLine();
            firstNumber = int.Parse(userInput);

            Console.Write("Enter the second number: ");
            userInput = Console.ReadLine();
            secondNumber = int.Parse(userInput);

            sum = firstNumber + secondNumber;

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, sum);
            Console.ReadKey(true);
        }
    }
}
