string nameOfActor = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string pointsGiver = Console.ReadLine();
    double pointFromGiver = double.Parse(Console.ReadLine());

    points += ((pointsGiver.Length * pointFromGiver) / 2);

    if(points >= 1250.5)
{
        Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {points:f1}!");
        break;
    }
}

if (points < 1250.5)
{
    Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - points:f1} more!");
}