//string putIn = Console.ReadLine();
//double sum = 0;

//while (putIn != "NoMoreMoney")
//{
//    Console.WriteLine($"Increase: {double.Parse(putIn):f2}");
//    sum += double.Parse(putIn);
//    putIn = Console.ReadLine();
//    if (double.Parse(putIn) < 0)
//    {
//        Console.WriteLine("Invalid operation!");
//        break;
//    }
//}
//Console.WriteLine($"Total: {sum:f2}");

string input = Console.ReadLine();

double balance = 0;
while (input != "NoMoreMoney")
{
    double amount = double.Parse(input);

    if (amount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {amount:f2}");
    balance += amount;

    input = Console.ReadLine();
}
Console.WriteLine($"Total: {balance:f2}");