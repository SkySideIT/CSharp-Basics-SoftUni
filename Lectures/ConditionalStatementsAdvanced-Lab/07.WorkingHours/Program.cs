﻿int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (day == "Monday" || day == "Tuesday" || day == "Wednesdat" || day == "Thursday" || day == "Friday" || day == "Saturday") 
{
	if (hour >= 10 && hour <= 18)
	{
        Console.WriteLine("open");
    }
	else
	{
        Console.WriteLine("closed");
    }
}
else
{
    Console.WriteLine("closed");
}