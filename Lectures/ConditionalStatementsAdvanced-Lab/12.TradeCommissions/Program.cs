string city = Console.ReadLine();
double sells = double.Parse(Console.ReadLine());

double commision = 0;

if(city == "Sofia")
{
	if (sells >= 0 && sells <= 500)
	{
		commision = sells * 0.05;
	}
	else if (sells > 500 && sells <= 1000)
    {
        commision = sells * 0.07;
    }
    else if (sells > 1000 && sells <= 10000)
    {
        commision = sells * 0.08;
    }
    else if (sells > 10000)
    {
        commision = sells * 0.12;
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if(city == "Varna")
{
    if (sells >= 0 && sells <= 500)
    {
        commision = sells * 0.045;
    }
    else if (sells > 500 && sells <= 1000)
    {
        commision = sells * 0.075;
    }
    else if (sells > 1000 && sells <= 10000)
    {
        commision = sells * 0.10;
    }
    else if (sells > 10000)
    {
        commision = sells * 0.13;
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if(city == "Plovdiv")
{
    if (sells >= 0 && sells <= 500)
    {
        commision = sells * 0.055;
    }
    else if (sells > 500 && sells <= 1000)
    {
        commision = sells * 0.08;
    }
    else if (sells > 1000 && sells <= 10000)
    {
        commision = sells * 0.12;
    }
    else if (sells > 10000)
    {
        commision = sells * 0.145;
    }
    else
    {
        Console.WriteLine("error");
    }
}
else
{
    Console.WriteLine("error");
}

if (commision != 0)
{
    Console.WriteLine($"{commision:f2}");
}