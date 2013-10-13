# Lesson 2: Decision Making

## 2.1 Flowcharts
Forget about programming for a second and think about a car. When a group of engineers design a car, they have a high-level blueprint for the whole car. This blueprint refers to many other blueprints which capture the details of the smaller working parts such as the engine, the steering wheels, and so on.

For computer programs, their "blueprints" can be represented by flowcharts. Larger programs will have many flowcharts, and smaller programs will have fewer flowcharts. Flowcharts capture the ideas behind a program and how it executes.

> In reality, flowcharts aren't used as often as one might think. Seasoned programmer can form ideas in their heads and start coding. However, it is important to get into the habit of thinking in terms of how a program executes.

### 2.1.1 The beginning and The end
Every program has a beginning and an end – as do flowcharts. A complete flowchart often start with the word **"Begin"** inside an oval shape and ends with the word **"End"** inside another oval shape. To a program which does absolutely nothing, the flowchart would look like this:

![Empty Flowchart](screenshots/02/EmptyFlowchart.png)

Notice that an arrow is used to guide the direction of which the program is executing.

> There aren't hard-golden rules to the shape of different pieces inside a flowchart. However, there are conventions that most people follow. You might occasionally see flowcharts that start with circles instead of ovals. Same goes for the other shapes in the rest of this lesson.

### 2.1.2 Input and Output (I/O)
In lesson one, you have written programs which output to the console window and take user input. Within a flowchart, **parallelograms** (or slanted rectangles) are often used to represent I/O operations.

Example of an output parallelogram:

![Output Parallelogram](screenshots/02/OutputParallelogram.png)

Example of an input parallelogram:

![Input Parallelogram](screenshots/02/InputParallelogram.png)

Example of a program which prints out "Hello world!" to the console:

![Hello World Flowchart](screenshots/02/HelloWorldFlowchart.png)

In this case, even though the program outputs to the console window, the flowchart didn't get into the specifics. Flowcharts capture ideas which can be implemented in different programming languages and systems. However, there are cases where it is necessary to get specific, such as differentiating between writing to the console window and writing to a file, in the same program.

### 2.1.3 Actions
Rectangles are used to describe actions which don't interact with users (not I/O). 

Example of an action which increments the value `X` by 1:

![Increment X](screenshots/02/ActionIncX.png)

Inside a complete program:

![Complete increment X flowchart](screenshots/02/CompleteIncXFlowchart.png)

### 2.1.4 Conditions
So far, all the programs we have written or designed just follow one straight path from the beginning to the end. Most programs are more complicated than that – they often have to decide if one action should be taken rather than another. To know which actions should be taken, a program would evaluate if some condition is satisfied. 

In the world of flowcharts, conditions are usually represented by a diamond shape, with two arrows pointing out. One arrow is annotated with a **"Yes"** or **"Y"**. The other arrow is annotated with a **"No"** or **"N"**. The program will go with the "Yes" path if the condition inside the diamond is satisfied. Respectively, it will go with the "No" path if the condition is not satisfied.

The following example represents a condition which the value of `X` is less than 5:

![X less than 5 condition](screenshots/02/XLessThan5Cond.png)

Inside the context of a program:

![Complete less than 5 flowchart](screenshots/02/CompleteLessThan5Flowchart.png)

This program asks the user for an integer number. Based on whether the number is less than 5 or greater than 5, it will print out an appropriate message.

### 2.1.5 Example

Let's suppose we want to design a program which will **have the user input an integer. If the number is higher than 10 then print the message "This number is larger than 10". Either way, let the user know if the number is odd or even.**

![Full example flowchart](screenshots/02/FullExampleFlowchart.png)

Let's interpret this chart:

1. The program begins 
2. The user is asked for an integer `X`. 
3. Then the program checks if `X` is greater than `10`. If it's true then the program prints a message. Because we are going to the next part of the program either way, the `Output "X larger than 10"` (from the "Yes" path) points back to the "No" path. 
4. The program checks if `X` is an even number, then print out the corresponding message.
6. The program ends.

## 2.2 Code comments

If you view the source code of some larger programs, you'd often see comments in the code. Comments are used to document the intent of the programmer, note why a piece of code is written in certain way. **Comments are very important, because a piece of code is often revisited and maintained.** Comments are usually in English (or whichever natural language your team speaks) and they are ignored when the program is built and executed. There are two ways of writing comments in C#:

### 2.2.1 Single-line comment
On each line of C# code, anything after two slashes `//` is considered comment -- the only exception is when they are part of a string (inside to double-quote symbols). For example:

```c#
static void Main(string args[])
{
	Console.WriteLine("// are used for single-line comments "); // ignored
}
```

```c#
static void Main(string args[])
{
	int x;
	float half;
	
	half = x / 2.0F; // need to divide by 2.0F to make it a float operation
}
```

### 2.2.2 Contained or Multi-line comment
Even though single-line comments are used very frequently, there are times when it's not convenient to use them. The other alternative is to put your comment between `/*` and `*/`. 

In the following example, we span our comment among multiple lines to note the author and the date which the code is written:

```c#
static void Main(string args[])
{
	/*
	Written by John Doe
	Date: December 1, 2011
	*/
}
```

There are also times when you only want to put comment on a small part of the line. The following example uses `/*` and `*/` to contain the comments inside a line.

```c#
static void Main(string args[])
{
   Console.WriteLine("It is now {0}", DateTime.Now /* {0} */);
}