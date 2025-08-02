int height = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int piecesNumber = height * width;
string input = Console.ReadLine();

while (input != "STOP" || piecesNumber <= 0)
{
    piecesNumber -= int.Parse(input);
    if (piecesNumber < 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(piecesNumber)} pieces more.");
        break;
    }
    input = Console.ReadLine();
}
if (input == "STOP")
{
    Console.WriteLine($"{piecesNumber} pieces are left.");
}