double budgetForActors = double.Parse(Console.ReadLine());
string input = Console.ReadLine();

while (input != "ACTION")
{
	if (input.Length <= 15)
	{
		double payCheck = double.Parse(Console.ReadLine());
		budgetForActors -= payCheck;
		if (budgetForActors < 0)
		{
            Console.WriteLine($"We need {Math.Abs(budgetForActors):f2} leva for our actors.");
			break;
        }
	}
	else 
	{
		budgetForActors *= 0.80;
	}
	input = Console.ReadLine();
}

if (input == "ACTION")
{
    Console.WriteLine($"We are left with {budgetForActors:f2} leva.");
}