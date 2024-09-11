// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int number2 =  int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do? ");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
string input = Console.ReadLine();

if (input == "A" || input == "a")
{
    int result = number1 + number2;
    Console.WriteLine($"{number1} + {number2} = {result}");
}
else if (input == "S" || input == "s")
{
    int result = number1 - number2;
    Console.WriteLine($"{number1} - {number2} = {result}");
}
else if (input == "M" || input == "m")
{
    int result = number1 * number2;
    Console.WriteLine($"{number1} * {number2} = {result}");
}
else
{
    Console.WriteLine("Invalid selection, sorry!");
}