double record = double.Parse(Console.ReadLine());
double metres  = double.Parse(Console.ReadLine());
double secFor1metre = double.Parse(Console.ReadLine());

double secondsNeeded = metres * secFor1metre;
double delaySeconds = Math.Floor(metres / 15) * 12.5;
double sumTime = secondsNeeded + delaySeconds;
if (sumTime < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {sumTime:f2} seconds.");
}
else
{
    double neededSecond = sumTime - record;
    Console.WriteLine($"No, he failed! He was {neededSecond:f2} seconds slower.");
}