int numberTournaments = int.Parse(Console.ReadLine());
int startingPoints =  int.Parse(Console.ReadLine());
double sum = 0;
double countWins = 0;

for (int i = 0; i < numberTournaments; i++)
{
    string stageOfTournament = Console.ReadLine();
	if (stageOfTournament == "W")
	{
		sum += 2000;
        countWins++;
	}
	else if (stageOfTournament == "F")
	{
        sum += 1200;
    }
    else if (stageOfTournament == "SF")
    {
        sum += 720;
    }
}

double finalPoints = sum + startingPoints;
Console.WriteLine("Final points: " + finalPoints);
Console.WriteLine("Average points: " + Math.Floor(sum/numberTournaments));
Console.WriteLine($"{((countWins/numberTournaments) * 100):f2}%");