int number = int.Parse(Console.ReadLine());
int currentNum = 1;
bool isEnded = false;

for (int i = 1; i <= number; i++)
{
	for (int j = 1; j <= i; j++)
	{
        Console.Write($"{currentNum} ");
        currentNum++;
        if (currentNum > number)
        {
            isEnded = true;
            break;
        }
    }
    Console.WriteLine();
    if (isEnded)
    {
        break;
    }
}