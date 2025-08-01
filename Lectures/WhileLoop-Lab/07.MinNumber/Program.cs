string input = Console.ReadLine();
double minValue = double.MaxValue;

while (input != "Stop")
{
    double num = double.Parse(input);

    if (num < minValue)
    {
        minValue = num;
    }

    input = Console.ReadLine();
}
Console.WriteLine(minValue);