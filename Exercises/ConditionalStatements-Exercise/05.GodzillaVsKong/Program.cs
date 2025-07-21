double budget = double.Parse(Console.ReadLine());
int numStatists = int.Parse(Console.ReadLine());
double clothesForOne =  double.Parse(Console.ReadLine());

double decor = budget * 0.10;
if (numStatists > 150)
{
    clothesForOne = clothesForOne * 0.90; 
}
double clothesAll = numStatists * clothesForOne;
double sum = decor + clothesAll;
if (sum > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(sum - budget):f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {(budget - sum):f2} leva left.");
}