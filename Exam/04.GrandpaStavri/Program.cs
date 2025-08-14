int days = int.Parse(Console.ReadLine());

double totalLitres = 0;
double totalDegrees = 0;

for (int i = 0; i < days; i++)
{
    double litres = double.Parse(Console.ReadLine());
    totalLitres += litres;
    double degrees = double.Parse(Console.ReadLine());
    totalDegrees += litres * degrees;
}

double totalDegreesAverage = totalDegrees / totalLitres;
Console.WriteLine($"Liter: {totalLitres:f2}");
Console.WriteLine($"Degrees: {totalDegreesAverage:f2}");
if (totalDegreesAverage < 38)
{
    Console.WriteLine($"Not good, you should baking!");
}
else if (totalDegreesAverage > 38 && totalDegreesAverage < 42)
{
    Console.WriteLine($"Super!");
}
else
{
    Console.WriteLine($"Dilution with distilled water!");
}