int target = int.Parse(Console.ReadLine());
string input =  Console.ReadLine();

double moneyMade = 0;

while (input != "closed")
{
	if (input == "haircut")
	{
		input = Console.ReadLine();
        if (input == "mens")
        {
            moneyMade += 15;
        }
        else if (input == "ladies")
        {
            moneyMade += 20;
        }
        else
        {
            moneyMade += 10;
        }
    }
    else
    {
        input = Console.ReadLine();
        if (input == "touch up")
        {
            moneyMade += 20;
        }
        else
        {
            moneyMade += 30;
        }
    }

    if (moneyMade >= target)
    {
        Console.WriteLine("You have reached your target for the day!");
        Console.WriteLine($"Earned money: {moneyMade}lv.");
        break;
    }

    input = Console.ReadLine();
}

if (input == "closed")
{
    if (moneyMade >= target)
    {
        Console.WriteLine("You have reached your target for the day!");
        Console.WriteLine($"Earned money: {moneyMade}lv.");
    }
    else
    {
        Console.WriteLine($"Target not reached! You need {target - moneyMade}lv. more.");
        Console.WriteLine($"Earned money: {moneyMade}lv.");
    }
}