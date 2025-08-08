int totalMatches = 0;
int wonMatches = 0;

string tournament = Console.ReadLine();
while (tournament != "End of tournaments")
{
    int matchesCount = int.Parse(Console.ReadLine());
    for (int i = 0; i < matchesCount; i++)
    {
        int homePoints = int.Parse(Console.ReadLine());
        int awayPoints = int.Parse(Console.ReadLine());

        if (homePoints > awayPoints)
        {
            wonMatches++;
            Console.WriteLine($"Game {i+1} of tournament {tournament}: win with {homePoints - awayPoints} points.");
        }
        else
        {
            Console.WriteLine($"Game {i+1} of tournament {tournament}: lost with {awayPoints - homePoints} points.");
        }

        totalMatches++;
    }

    tournament = Console.ReadLine();
}

double winPercentage = 100.0 * wonMatches / totalMatches;
double lostPercentage = 100.0 * (totalMatches - wonMatches) / totalMatches;

if (tournament == "End of tournaments")
{
    Console.WriteLine($"{winPercentage:f2}% matches win");
    Console.WriteLine($"{lostPercentage:f2}% matches lost");
}