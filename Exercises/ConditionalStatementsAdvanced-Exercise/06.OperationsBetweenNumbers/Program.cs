double num1 = double.Parse(Console.ReadLine());
double num2 =  double.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());

double result = 0.0;
string type = "";

if (symbol == '+')
{
    result = num1 + num2;
    if (result % 2 == 0)
    {
        type = "even";
    }
    else 
    {
        type = "odd";
    }
    Console.WriteLine($"{num1} {symbol} {num2} = {result} - {type}");
}
else if (symbol == '-')
{
    result = num1 - num2;
    if (result % 2 == 0)
    {
        type = "even";
    }
    else
    {
        type = "odd";
    }
    Console.WriteLine($"{num1} {symbol} {num2} = {result} - {type}");
}
else if (symbol == '*')
{
    result = num1 * num2;
    if (result % 2 == 0)
    {
        type = "even";
    }
    else
    {
        type = "odd";
    }
    Console.WriteLine($"{num1} {symbol} {num2} = {result} - {type}");
}
else if (symbol == '/')
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else 
    {
        result = num1 / num2;
        Console.WriteLine($"{num1} {symbol} {num2} = {result:f2}");
    } 
}
else if (symbol == '%')
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        result = num1 % num2;
        Console.WriteLine($"{num1} {symbol} {num2} = {result}");
    }
}