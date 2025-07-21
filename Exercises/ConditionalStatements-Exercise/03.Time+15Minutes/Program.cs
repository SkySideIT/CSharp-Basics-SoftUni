int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int newTime = minutes + 15;
if (newTime > 59)
{
    hour += 1;
    minutes = newTime - 60;
}
else
{
    minutes = newTime;
}
if (hour > 23)
{
    hour = 0;
}
if (minutes < 10)
{
    Console.WriteLine($"{hour}:0{minutes}");
}
else
{
    Console.WriteLine($"{hour}:{minutes}");
}