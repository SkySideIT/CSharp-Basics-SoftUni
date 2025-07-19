using System.Drawing;

string figure = Console.ReadLine();
if (figure == "square")
{
    double a = double.Parse(Console.ReadLine());
    double lice = a * a;
    Console.WriteLine($"{lice:f3}");
}
else if (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double lice = a * b;
    Console.WriteLine($"{lice:f3}");
}
else if (figure == "circle")
{
    double a = double.Parse(Console.ReadLine());
    double lice = Math.PI * (a * a);
    Console.WriteLine($"{lice:f3}");
}
else if (figure == "triangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double lice = (a * b) / 2;
    Console.WriteLine($"{lice:f3}");
}