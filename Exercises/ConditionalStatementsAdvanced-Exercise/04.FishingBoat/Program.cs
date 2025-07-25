int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double rentBoat = 0;

if (season == "Spring")
{
    rentBoat = 3000;
}
else if (season == "Summer" || season == "Autumn")
{
    rentBoat = 4200;
}
else if (season == "Winter")
{
    rentBoat = 2600;
}

if (fishermen > 0 && fishermen <= 6)
{
    rentBoat = rentBoat * 0.90;
}
else if (fishermen > 6 && fishermen <= 11)
{
    rentBoat = rentBoat * 0.85;
}
else if (fishermen > 11)
{
    rentBoat = rentBoat * 0.75;
}

if (fishermen % 2 == 0 && season != "Autumn")
{
    rentBoat = rentBoat * 0.95;
}

if (budget >= rentBoat)
{
    Console.WriteLine($"Yes! You have {budget-rentBoat:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {rentBoat-budget:f2} leva.");
}