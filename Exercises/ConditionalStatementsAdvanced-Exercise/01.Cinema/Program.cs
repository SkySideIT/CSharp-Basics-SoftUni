string type = Console.ReadLine();
int numRows = int.Parse(Console.ReadLine());
int numCols = int.Parse(Console.ReadLine());

double seats = numCols * numRows;
double sum = 0;

if (type == "Premiere")
{
    sum = seats * 12.00;
    Console.WriteLine($"{sum:f2} leva");
}
else if (type == "Normal")
{
    sum = seats * 7.50;
    Console.WriteLine($"{sum:f2} leva");
}
else if (type == "Discount")
{
    sum = seats * 5.00;
    Console.WriteLine($"{sum:f2} leva");
}