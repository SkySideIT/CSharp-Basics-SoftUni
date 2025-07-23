string productName = Console.ReadLine();
string cityName = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;

if (cityName == "Sofia")
{
	if (productName == "coffee")
	{
        price = 0.50;
	}
	else if (productName == "water")
	{
        price = 0.80;
    }
    else if (productName == "beer")
    {
        price = 1.20;
    }
    else if (productName == "sweets")
    {
        price = 1.45;
    }
    else if (productName == "peanuts")
    {
        price = 1.60;
    }
}
else if (cityName == "Plovdiv")
{
    if (productName == "coffee")
    {
        price = 0.40;
    }
    else if (productName == "water")
    {
        price = 0.70;
    }
    else if (productName == "beer")
    {
        price = 1.15;
    }
    else if (productName == "sweets")
    {
        price = 1.30;
    }
    else if (productName == "peanuts")
    {
        price = 1.50;
    }
}
else if (cityName == "Varna")
{
    if (productName == "coffee")
    {
        price = 0.45;
    }
    else if (productName == "water")
    {
        price = 0.70;
    }
    else if (productName == "beer")
    {
        price = 1.10;
    }
    else if (productName == "sweets")
    {
        price = 1.35;
    }
    else if (productName == "peanuts")
    {
        price = 1.55;
    }
}

double sum = quantity * price;
Console.WriteLine(sum);