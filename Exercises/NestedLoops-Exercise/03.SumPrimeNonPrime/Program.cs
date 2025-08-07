string input = Console.ReadLine();

int sumPrime = 0;
int sumNonPrime = 0;

while (input != "stop")
{
    int number = int.Parse(input);
    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        number = 0;
    }
    bool isPrime = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime) 
    {
        sumPrime += number;
    }
    else
    {
        sumNonPrime += number;
    }

    input = Console.ReadLine();
}

if (input == "stop")
{
    Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
    Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
}

//------------------------------------------------------------------------------

//string input = Console.ReadLine();

//int sumPrime = 0;
//int sumNonPrime = 0;

//while (input != "stop")
//{
//    int number = int.Parse(input);
//    if (number < 0)
//    {
//        Console.WriteLine("Number is negative.");
//        number = 0;
//    }
//    else if (number != 2 && number % 2 == 0 || number != 3 && number % 3 == 0)
//    {
//        sumNonPrime += number;
//    }
//    else
//    {
//        sumPrime += number;
//    }
//    input = Console.ReadLine();
//}

//if (input == "stop")
//{
//    Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
//    Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
//}