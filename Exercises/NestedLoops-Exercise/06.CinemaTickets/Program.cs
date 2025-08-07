string name = Console.ReadLine();
double students = 0;
double standards = 0;
double kids = 0;

while (name != "Finish")
{
    double freeSeats = int.Parse(Console.ReadLine());
    string type = "";
    double givenTickets = 0;
    while (freeSeats > givenTickets)
    {
        type = Console.ReadLine();
        if (type == "End")
        {
            break;
        }
        givenTickets++;
        if (type == "standard")
        {
            standards++;
        }
        else if (type == "student")
        {
            students++;
        }
        else
        {
            kids++;
        }
    }
    Console.WriteLine($"{name} - {givenTickets/freeSeats * 100:f2}% full.");
    name = Console.ReadLine();
}

double totalTickets = students + standards + kids;
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{students / totalTickets * 100:f2}% student tickets.");
Console.WriteLine($"{standards / totalTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{kids / totalTickets * 100:f2}% kids tickets.");