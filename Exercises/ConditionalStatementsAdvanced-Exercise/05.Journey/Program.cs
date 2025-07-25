double budget = double.Parse(Console.ReadLine());
string season =  Console.ReadLine();

double cost = 0;
string destination = "";
string type = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
	{
        type = "Camp";
		cost = budget * 0.30;
	}
	else if(season == "winter")
	{
        type = "Hotel";
		cost = budget * 0.70;
	}
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        type = "Camp";
        cost = budget * 0.40;
    }
    else if (season == "winter")
    {
        type = "Hotel";
        cost = budget * 0.80;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    type = "Hotel";
    cost = budget * 0.90;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{type} - {cost:f2}");