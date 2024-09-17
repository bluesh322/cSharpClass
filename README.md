# [Home](..\README.md)

# Compiled C#

* Generates files in /bin/Debug/net{version#}
* ProjectName.exe executes the code
* ProjectName.dll is a dynamic link library, which is used by the .exe file to run the compiled code.
   * We already knew this but maybe look up what exactly the Dynamic Link Library is.

# Variables

int and string as variables. Mainly learning some syntax stuff.

`int a = 6, b = 4, c;`

## Reserved keywords

Can't declare variables of keywords

```
// Bad
int class = 2
```

Can use keywords as variables if you use '@' symbol before keyword but don't. God forbid I ever see this.

```
// Can do but also terrible.
int @class = 2
```

To rename a variable throughout a file use 'ctrl+R'

## Starting nested or different projects within a single Solution.

* To add a new project go to file->Add->New Project...


## Basic Operators

+, -, /, *, 

% modulo, get the remainder of a division.

## Var - implicit type variables

```
var variableName = 10;
// Would be an integer to the compiler. Should use sparingly.
```

## Console Input

```
string input = Console.ReadLine();
```

## Breakpoints - [F9]

Use breakpoints to pause a program in order to "just in time" debug a program by looking at 
values in variables and the current state of the application of a particular runtime.

## Switch & Breaks

Use switches for multiple choices needing to be made on one variable.

```
switch (variable)
{
	case "A":
	case "B":
	case "C":
	case "D":
	case "E":
		return "nice";
		break;
	case "F":
	case "G":
		return "not nice";
		break;
}
```

## While loops

Performs function based on a condition and can loop infinitely.

```
int i = 0;
while(i < 10)
{
	Console.WriteLine(i);
}
```

## DoWhile loops

Performs a function 1 time then may break out of the loop.

```

```

## For loops

Create a variable, a condition, and a stepping function and execute code within the loop.

```
for (int i = 0; i < 10; i++)
{
	Console.WriteLine("HelloWorld");
}
```

## Break

Break keyword exits out of a loop. Generally associated with Switch statements. 
Most of the time you don't want to use break as flow control of a program.

```
for(int i = 0; i < 10; i++)
{
	Console.WriteLine("HelloWorld");
	if(i > 6)
	{
	break;
	}
}

```

## Continue

Also stops the execution of a loop, but will proceed to the next iteration of the loop.

```
for(int i = 0; i < 10; i++)
{
	if(i % 2 == 1)
	{
	continue; // When an odd number is found, don't print i;
	}
	Console.WriteLine(i);
}

```

## Modulo '%'

Finds remainder of a division. Useful for finding odd/even pairs or only interacting every nth iteration.

```
for(int i = 0; i < 20; i++)
{
	if(i % 2 == 0)
	{
		Console.WriteLine(i); //Prints evens.
	}
}
```