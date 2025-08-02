string book = Console.ReadLine();
string guess = Console.ReadLine();
int count = 0;

while (guess != book)
{
    guess = Console.ReadLine();
    count++;
    if (guess == "No More Books")
    {
        Console.WriteLine($"The book you search is not here!");
        Console.WriteLine($"You checked {count} books.");
        break;
    }
}

if (guess == book)
{
    Console.WriteLine($"You checked {count} books and found it.");
}