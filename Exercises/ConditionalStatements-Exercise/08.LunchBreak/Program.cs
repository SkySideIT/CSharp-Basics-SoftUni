string name = Console.ReadLine();
int playTime = int.Parse(Console.ReadLine());
int pauseTime = int.Parse(Console.ReadLine());

double timeForLunch = pauseTime * 0.125;
double timeForRest = pauseTime * 0.25;
double timeLeft = pauseTime - (timeForLunch + timeForRest);

if (timeLeft >= playTime)
{
    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft - playTime)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(playTime - timeLeft)} more minutes.");
}