string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double studio = 0;
double apartment = 0;

if (month == "May" || month == "October")
{
	studio = nights * 50;
	apartment = nights * 65;
    if (nights > 7 && nights <= 14)
    {
        studio = studio * 0.95;
    }
    else if (nights > 14) 
    {
        studio = studio * 0.70;
        apartment = apartment * 0.90;
    }
}
else if (month == "June" || month == "September")
{
    studio = nights * 75.20;
    apartment = nights * 68.70;
    if (nights > 14)
    {
        apartment = apartment * 0.90;
    }
}
else if (month == "July" || month == "August")
{
    studio = nights * 76;
    apartment = nights * 77;
    if (nights > 14)
    {
        apartment = apartment * 0.90;
    }
}

Console.WriteLine($"Apartment: {apartment:f2} lv.");
Console.WriteLine($"Studio: {studio:f2} lv.");