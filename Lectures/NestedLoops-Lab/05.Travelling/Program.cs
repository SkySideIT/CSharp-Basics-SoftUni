string destination = Console.ReadLine();

while (destination != "End")
{
    double neededMoney = double.Parse(Console.ReadLine());

    double savedMoney = 0;
    while (savedMoney < neededMoney)
    {
        double savedAmoount = double.Parse(Console.ReadLine());
        savedMoney += savedAmoount;
    }

    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}