double neededMoney = double.Parse(Console.ReadLine());
double ownMoney =  double.Parse(Console.ReadLine());
int countDays = 0;
int spendingCounter = 0;

while (neededMoney > ownMoney)
{
    string transaction = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    countDays++;
    if (transaction == "spend")
    {
        spendingCounter++;
        if (spendingCounter == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{countDays}");
            break;
        }
        ownMoney -= money;
        if (ownMoney < 0)
        {
            ownMoney = 0;
        }
    }
    else
    {
        spendingCounter = 0;
        ownMoney += money;
    }
}

if (ownMoney >= neededMoney)
{
    Console.WriteLine($"You saved the money for {countDays} days.");
}