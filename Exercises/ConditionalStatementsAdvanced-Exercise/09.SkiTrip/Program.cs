int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string grade =  Console.ReadLine();

double sum = 0;

if (days < 10)
{
	if (roomType == "room for one person")
	{
		sum = (days - 1) * 18; 
	}
	else if (roomType == "apartment")
	{
        sum = ((days - 1) * 25) * 0.70;
    }
	else if (roomType == "president apartment")
	{
        sum = ((days - 1) * 35) * 0.90;
    }
}
else if (days >= 10 && days <= 15)
{
    if (roomType == "room for one person")
    {
        sum = (days - 1) * 18;
    }
    else if (roomType == "apartment")
    {
        sum = ((days - 1) * 25) * 0.65;
    }
    else if (roomType == "president apartment")
    {
        sum = ((days - 1) * 35) * 0.85;
    }
}
else if (days > 15)
{
    if (roomType == "room for one person")
    {
        sum = (days - 1) * 18;
    }
    else if (roomType == "apartment")
    {
        sum = ((days - 1) * 25) * 0.50;
    }
    else if (roomType == "president apartment")
    {
        sum = ((days - 1) * 35) * 0.80;
    }
}
if (grade == "positive")
{
    sum = sum * 1.25;
}
else if (grade == "negative")
{
    sum = sum * 0.90;
}
Console.WriteLine($"{sum:f2}");