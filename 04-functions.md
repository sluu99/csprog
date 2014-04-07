# Lesson 4: Functions

## 4.1 Introduction
Computer programs often needs to perform the same tasks many times. Think about your previous exercise "Max of Three."
In that exercise, you ask the user to enter 3 numbers.
You probably had 3 lines of `Console.WriteLine`, 3 lines of `Console.ReadLine`, and 3 lines of `int.Parse`.
After gathering the input, we used an `if` statement to find the the larger number between X & Y,
then used another `if` statement to compare that larger number with Z.

As you can see, that was quite a simple program and we already have so much repetition.
Imagine something larger like an accounting program, it would be a disaster to have to write the same piece
of code over and over again to calculate the total revenue of each month within a fiscal year.
In addition, it's not a good idea to repeat the same or similar piece of code over and over again.
More code means more potential for typos, more mistakes, and more bugs.

This lesson will introduce us to *functions* (all so known as *methods*).
Think about it as a mechanism to **name** a block of code
and we can always execute that block of code by calling its names.


## 4.2 "void" functions
You may not know this, but you have already seen a function. Let's revisit our "Hello world" program:

```c#
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }
    }
}
```

In this program, we have a single function called `Main`.
`Main` is a special function that C# recognizes as the entry point of the program.
Without it, C# won't know what to do when you click run.
Now that you have an idea what a C# function looks like, let's write our own!

Imagine that you're collaborating with a team of many people to write a program and you predict that the program will say hello to the user multiple times.
While everyone has an idea that we should say hello, you're seeing through out your program different variations of it:
"Hello world," "Hi there," "What's up," etc.
A simple solution is to have everyone call the same function `SayHello` whenever they want to greet the user.
Here's what the program would look like:

```c#
class Program
{
    static void SayHello()
    {
        Console.WriteLine("Hello there!");
    }
    
    static void Main()
    {
        SayHello();
        SayHello(); // we're so excited that we are greeting the user twice!!
    }
}
```

It is pretty straight forward to declare a new function (for the purpose of this course, all function decorations start with `static`):
* The function signature starts with the `void` keyword, we'll learn more about this part of the function later in this lesson.
* The next part is the function name. In this case, our function is named "SayHello."
* The function signature ends with a pair of `parentheses`. We will also explore what these are for later in this lesson.
* After the function signature is a pair of curly braces `{ }` that encloses the body of the function.


## 4.3 Function naming conventions
* C# (and .NET) convention uses "PascalCase" for function names, meaning that each word of the function name starts with an captialized letter.
* Function names must begin with a captialized alphabet letter. Any alpha-numeric characters are acceptable after that.
* It's recommended that function names start with a verb.

Example of some function names: 
* SayHello
* Sum
* Max
* MaxOf3
* IsLeapYear


## 4.4 Function parameters
So far we've written a pretty simple function. `SayHello` just does its own thing whenever it's called. What if we want a function that can take input from the outside world?

Consider our "Max of Three" program again: in this program, we prompt the user to enter integers 3 different times:

```c#
Console.Write("Please enter a value for X: ");
// ...
Console.Write("PLease enter a value forY: ");
// ...
Console.Write("Plaese enter a value for Z:");
```

If you're lazy and careless like me, you probably didn't type all 3 lines but copied them instead. And in the process of changing each line, I've made mistakes here and there. Wouldn't it be nice to have a function that can take in a variable name and print the same prompt for us everytime? Well, it's not that hard!

```c#
class Program
{
    static void PromptUser(string variableName)
    {
        variableName = variableName.Trim(); // ???
        Console.Write("Please enter a value for {0}: ", variableName);
    }
    
    static void Main(string[] args)
    {
        PromptUser("X");
        PromptUser(" Y ");
        PromptUser("Z");
    }
}
```

Let's disect our function decoration in this example!

* The function signature still starts with the keyword `void`
* In this example, we named our function "PromptUser."
* This time, instead of a pair of empty parentheses, we have `string variableName` inside them, looking very similar to declaring a variable. For this function, `variableName` is called a parameter. This parameter has the type of `string`.

This function signature tells C# that anyone who calls `PromptUser` must provide a string. Inside the function, this string will be known as `variableName`. If you tried to call this function without providing a variable name or provide the function with an integer, Visual Studio (the compiler) would error out.

> Notice that I have two extra white spaces around "Y." I'll let you figure out why I intentially do this and what `variableName.Trim()` does.

## 4.5 Parameter naming conventions
Naming parameters is very similar to naming variables. Besides picking a meaningful name, here are the general rules of thumb:
* C# uses "camelCase" for parameter names, meaning that the first world is lower case. The other words in the name are captialized.
* Parameter names must begin with a lower case alphabet letter. Any alpha-numeric characters can follow.

Example of some pareter names:
* year
* x
* userName
* encryptedCreditCardNumber
* n1
* n2

## 4.6 Multiple parameters
A function can have multiple parameters. The parameters are separated by commas.
The example below shows a function which takes two parameters.
Notice that even though the parameters are of the same type, the parameter type is still repeated for each parameter.

```c#
static void Greet(string name, string language)
{
    
}
```

## 4.7 Return type
So far, the functions we have writen do not return anything. Meaning that they perform certain actions, and then the function ends. There are many cases when it's useful for a function to return some value, such as a function which calculate the average of three numbers. It would be pretty pointless if the function does all the calculations and just keep the result to itself.

Here's a function which calculate the average of three numbers:

```c#
static float Average(int x, int y, int z)
{
    long total = x + y + z;
    float average = total / 3.0f;
    
    return average;
}
```

At a first glance, this function looks very similar to the functions we have seen so far &ndash; it is.
The difference is that we had replaced the keyword `void` with `float`. This lets C# know that the function is returning a floating point number.

As you might have guessed, the `return` command returns a value and quit the function. *When a `return` command is executed, it completely quits the function and anything after it will be ignored.*

Another thing I want to point your attention to is the data types used in this function. It is not a coincident that the function uses a `long` variable to hold the total. Because each data type has a maximum limit, it took into consideration that adding three `int`s together might **overflow** if the values are two large.

> For science: What is the maximum value for an `int`, and a `long`? What is the best way to obtain that value in C#? What happens when we try to overflow an `int`?

## 4.8 Variable scope
Consider this example:

```c#
static void AddOne(int x)
{
    x = x + 1;
    Console.WriteLine("Two: {0}", x);
}

static void Main(string args[])
{
    int x = 10;
    
    Console.WriteLine("One: {0}", x);
    
    AddOne(x);
    
    Console.WriteLine("Three: {0}", x);
}
```

This program will print out three lines:

```
One: 10
Two: 11
Three: 10
```

Inside the `Main` function, the value of `x` never changed. That is because when `x` is passed into `AddOne`, the computer made a copy of its value. This is also true for the data types that we have used so far: `char`, `short`, `long`, `float`, `double`, `string`, ...

The correct way to write this program should be

```c#
static int AddOne(int x)
{
    x = x + 1;
    Console.WriteLine("Two: {0}", x);
    
    return x;
}

static void Main(string args[])
{
    int x = 10;
    
    Console.WriteLine("One: {0}", x);
    
    x = AddOne(x);
    
    Console.WriteLine("Three: {0}", x);
}
```
