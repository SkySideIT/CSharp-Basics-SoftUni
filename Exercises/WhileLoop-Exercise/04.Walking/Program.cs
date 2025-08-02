int sumSteps = 0;

while (sumSteps < 10000)
{
    string steps = Console.ReadLine();
    if (steps == "Going home")
    {
        sumSteps += int.Parse(Console.ReadLine());
        break;
    }
    sumSteps += int.Parse(steps);
}

if (sumSteps >= 10000)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{sumSteps - 10000} steps over the goal!");
}
else
{
    Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
}