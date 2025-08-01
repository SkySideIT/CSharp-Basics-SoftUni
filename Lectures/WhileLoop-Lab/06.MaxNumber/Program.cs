string input = Console.ReadLine();
double maxValue = double.MinValue;

while (input != "Stop")
{
    double num = double.Parse(input);

    if (num > maxValue)
    {
        maxValue = num;
    }

    input = Console.ReadLine();
}
Console.WriteLine(maxValue);