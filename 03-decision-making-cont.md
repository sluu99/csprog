# Lesson 3: Decision Making (cont.)

The last lesson introduces to us decision making in flowcharts.
Base on what we've learned about program flows, this lesson will show us how to write code for it.

## 3.1 The if statement
C# (and most programming languages) supports programmatic decision making via some kind of `if` statement. Let's explore the C# `if` statement with an example!

The program: Asks the user for an integer number and display a message if the number is greater than 5.

```c#
int x;
string input;

input = Console.ReadLine();
x = int.Parse(input);

if (x > 5)
{
    Console.WriteLine("Greater than 5");
}

```

Let's dissect the code a little! 

* At this point, we should be familiar with the first four lines of code: declaring variables and reading user input.
* The next line is what an `if` statement looks like. It starts with an `if` (duh) and the condition is enclosed within a pair of parentheses. This is the **"Yes" branch** of the diamond shape (see 2.1.4).
* The body (or the action) of the `if` statement is between a pair of curly braces, `{` and `}`.

## 3.2 The body
In the previous example, the body if the `if` statement is enclosed inside a pair of curly braces. Something I didn't mention is that those curly braces are actually **optional if you have one action in the body**.

```c#
if (x > 5)
    Console.WriteLine("Greater than 5");
```

The example above works exactly the same. In fact, you don't even need to put the body on a new line! The next two examples are all equivalent:

```c#
if (x > 5) Console.WriteLine("Greater than 5");
```

```c#
if (x > 5) { Console.WriteLine("Greater than 5"); }
```

**So when do we need the curly braces?** When there's more than one statement in the body. This is the biggest got-cha to those not familiar with the if statements. Let's look at an example!

```c#
if (x > 5)
	Console.WriteLine("Greater than 5");
Console.WriteLine("This line will appear regardless of X");
```

As you can guess, the second `WriteLine` statement is executed even if `x` is less than `5`. Indentation does not matter either, since they are only for readability:

```c#
if (x > 5)
	Console.WriteLine("Greater than 5");
	Console.WriteLine("This line will appear even if x is greater than 5");
	Console.WriteLine("So will this line. Don't let the indentation fool you!");
``` 

This is when curly braces come handy:
```c#
if (x > 5)
{
	Console.WriteLine("Greater than 5");
	Console.WriteLine("This line will only appear if x is greater than 5");
}
```

For the rest of this course, I'll always enclose the body between curly braces to avoid confusion.

## 3.3 The else statement
So far we have only seen the `if` statement (or the *Yes* branch of the diamond). This section will introduce to us the `else` statement, the *No* branch of the diamond.

```c#
if (x > 5)
{
	Console.WriteLine("Greater than 5");
}
else
{
	Console.WriteLine("Less than or equal to 5");
}
```

## 3.4 Other examples

```c#
if (x > 5)
{
	Console.WriteLine("Greater than 5");
}
else
{
	if (x < 5)
	{
		Console.WriteLine("Less than 5");
	}
	else
	{
		Console.WriteLine("Equals to 5");
	}
}
```

The example above can be written in a more condensed way by removing the curly braces of the first else branch:

```c#
if (x > 5)
{
	Console.WriteLine("Greater than 5");
}
else
	if (x < 5)
	{
		Console.WriteLine("Less than 5");
	}
	else
	{
		Console.WriteLine("Equals to 5");
	}
```

Then remove the blank line:

```c#
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
```

## 3.5 Exercises

Write the C# programs for the flowcharts from lesson 2 exericses.
