int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
int height =  int.Parse(Console.ReadLine());
int volume = width * height * lenght;
string input  = Console.ReadLine();

while (input != "Done")
{
    volume -= int.Parse(input);
	if (volume < 0)
	{
        Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
        break;
    }
    input = Console.ReadLine();
}
if (input == "Done")
{
    Console.WriteLine($"{volume} Cubic meters left.");
}