string flowers = Console.ReadLine();
int number = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double sum = 0;

if (flowers == "Roses")
{
    sum = number * 5.00;
	if (number > 80)
	{
		sum = sum * 0.90;
	}
}
else if (flowers == "Dahlias")
{
	sum = number * 3.80;
    if (number > 90)
    {
        sum = sum * 0.85;
    }
}
else if (flowers == "Tulips")
{
    sum = number * 2.80;
    if (number > 80)
    {
        sum = sum * 0.85;
    }
}
else if (flowers == "Narcissus")
{
    sum = number * 3.00;
    if (number < 120)
    {
        sum = sum * 1.15;
    }
}
else if (flowers == "Gladiolus")
{
    sum = number * 2.50;
    if (number < 80)
    {
        sum = sum * 1.20;
    }
}

if (sum <= budget)
{
    Console.WriteLine($"Hey, you have a great garden with {number} {flowers} and {budget-sum:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {sum-budget:f2} leva more.");
}