string drinkName = Console.ReadLine();
string sugar =  Console.ReadLine();
int numberOfDrinks = int.Parse(Console.ReadLine());

double drinkPrice = 0;

if (drinkName == "Espresso")
{
	if (sugar == "Without")
	{
		drinkPrice = 0.90 * 0.65;
	}
	else if(sugar == "Normal")
	{
		drinkPrice = 1;
	}
	else
	{
		drinkPrice = 1.20;
	}

    if (numberOfDrinks >= 5)
    {
        drinkPrice *= 0.75;
    }
}
else if (drinkName == "Cappuccino")
{
    if (sugar == "Without")
    {
        drinkPrice = 1 * 0.65;
    }
    else if (sugar == "Normal")
    {
        drinkPrice = 1.20;
    }
    else
    {
        drinkPrice = 1.60;
    }
}
else
{
    if (sugar == "Without")
    {
        drinkPrice = 0.50 * 0.65;
    }
    else if (sugar == "Normal")
    {
        drinkPrice = 0.60;
    }
    else
    {
        drinkPrice = 0.70;
    }
}

double totalSum = drinkPrice * numberOfDrinks;
if (totalSum > 15)
{
    totalSum *= 0.80;
}

Console.WriteLine($"You bought {numberOfDrinks} cups of {drinkName} for {totalSum:f2} lv.");