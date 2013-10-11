## Lesson 1 Exercise solution

The actual projects for these solutions can be found in the `code` folder.

### Solution for 1.6.1 Christmas tree

The purpose for this exercise was to get you comfortable with working in Visual Studio and writing C# code. Even though the main goal of the class is not about Visual Studio nor the C# language itself, it is helpful to be fluent with them so that they won't get in the way of the actual goal of learning programming.

**Review:** to create a new project in Visual Studio, go to **Menu File → New Project**. More details can be found in section *1.1.2*.

The actual code in `Program.cs` for this solution:

```c#
using System;

namespace Lesson1ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");
            Console.WriteLine("    *");

            Console.ReadKey(true);
        }
    }
}
```

The code is pretty self-explanatory. The first few lines of code write each line of the Christmas tree to the console window. `Console.ReadKey` pauses the program until user hits a key, then the program quits.

Alternatively, I suspect that many of you would have written the tree like this:

```c#
Console.WriteLine("    *    ");
Console.WriteLine("   ***   ");
Console.WriteLine("  *****  ");
Console.WriteLine(" ******* ");
Console.WriteLine("*********");
Console.WriteLine("    *    ");
```

This is a perfectly fine solution, too. Yes, the later solution would actually print out those extra white-spaces at the end, but the difference in performance is negligible in this case. Programmers often have to decide to trade off little performance to make their code more readable, understandable, and maintainable. Clever code is not necessary good code.

### Solution for 1.6.2 Average

This exercise emphasizes on getting user input from the console window and familiarizing with variables and mathematical operations. The full project can be found in the `code` folder; I'll split the code out to smaller snippets and explain one snippet at a time:

```c#
string userInput;
int num1;
int num2;
int num3;
double average;
```
These 5 lines of code declare the variables that we are going to use for the program. 
* The first line declares a `string` variable to receive user input from the console window; remember that `Console.ReadLine` always gives us a `string`.
* The next 3 lines declares 3 `int` (integer) variables. Each of them will hold the value for each number the user enters.
* The 5th line declares a `double` variable to hold the average value that we will calculate. I was being a little tricky and did not suggest a specific data type for the average. However, the example output `3.66666666666667` had way more precision than a `float` variable would be able to handle. Always consider data precision when you're dealing with float-point numbers.

```c#
Console.Write("Enter the first number: ");
userInput = Console.ReadLine();
num1 = int.Parse(userInput);
```
These three lines of code asks the user to enter a number.
* Hopefully you're familiar with `Console.Write` and `Console.WriteLine` at this point.
* We use `Console.ReadLine` to get what the user typed. This function always gives us a `string`, which is assigned to `userInput`.
* Next, we use `int.Parse` to convert a string into an integer and assigns it to the variable `num1`.

The code to get the 2nd and 3rd number is very similar.

```c#
average = (num1 + num2 + num3) / 3.0D;
Console.WriteLine("Average of {0}, {1}, and {2} is {3}", num1, num2, num3, average);

Console.ReadKey(true);
```
This is the core logic of the exercise.
* On the first line of code, we add the first 3 numbers together, and then divide them by 3. Notice that I had to specify `3.0D` to make it a `double` operation. If I were to only specify `3`, the whole operation would be considered an integer operations and anything after the decimal point would be stripped out. Also notice the operator precedence.
* The next line of code uses `{0}`, `{1}`, etc. to write out the four numbers. Remember, the number starts with zero.
* As usual, we end the the code with `Console.ReadKey` to prevent the program from quitting immediately. 