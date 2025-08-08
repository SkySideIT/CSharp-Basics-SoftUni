int numberOfGroups = int.Parse(Console.ReadLine());

double sum = 0;
double musala = 0;
double monblan = 0;
double kili = 0;
double k2 = 0;
double everset = 0;

for (int i = 0; i < numberOfGroups; i++)
{
    int numberOfPeople = int.Parse(Console.ReadLine());
	sum += numberOfPeople;
	if (numberOfPeople <= 5)
	{
		musala += numberOfPeople;
	}
	else if (numberOfPeople > 5 && numberOfPeople <= 12)
	{
		monblan += numberOfPeople;
	}
    else if (numberOfPeople > 12 && numberOfPeople <= 25)
    {
		kili += numberOfPeople;
    }
    else if (numberOfPeople > 25 && numberOfPeople <= 40)
    {
		k2 += numberOfPeople;
    }
	else 
	{
		everset += numberOfPeople;
	}
}

Console.WriteLine($"{musala / sum * 100:f2}%");
Console.WriteLine($"{monblan / sum * 100:f2}%");
Console.WriteLine($"{kili / sum * 100:f2}%");
Console.WriteLine($"{k2 / sum * 100:f2}%");
Console.WriteLine($"{everset / sum * 100:f2}%");