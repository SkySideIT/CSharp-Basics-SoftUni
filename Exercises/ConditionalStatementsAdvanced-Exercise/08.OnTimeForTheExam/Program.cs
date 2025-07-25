int examHour = int.Parse(Console.ReadLine());
int examMin = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMin = int.Parse(Console.ReadLine());

int examTime = examMin + examHour * 60;
int arrivalTime = arrivalMin + arrivalHour * 60;
int differenceA = examTime - arrivalTime;
int differenceB = arrivalTime - examTime;

if (differenceA >= 0 && differenceA <= 30)
{
    Console.WriteLine("On time");
    Console.WriteLine($"{differenceA} minutes before the start");
}
else if (differenceB > 0)
{
    Console.WriteLine("Late");
    if (differenceB < 60)
    {
        Console.WriteLine($"{differenceB} minutes after the start");
    }
    else if (differenceB >= 60 && differenceB < 70)
    {
        Console.WriteLine($"{differenceB /60}:0{differenceB %60} hours after the start");
    }
    else
    {
        Console.WriteLine($"{differenceB /60}:{differenceB %60} hours after the start");
    }
}
else
{
    Console.WriteLine($"Early");
    if (differenceA < 60)
    {
        Console.WriteLine($"{differenceA} minutes before the start");
    }
    else if (differenceA % 60 >= 0 && differenceA % 60 < 10)
    {
        Console.WriteLine($"{differenceA / 60}:0{differenceA % 60} hours before the start");
    }
    else
    {
        Console.WriteLine($"{differenceA / 60}:{differenceA % 60} hours before the start");
    }
}