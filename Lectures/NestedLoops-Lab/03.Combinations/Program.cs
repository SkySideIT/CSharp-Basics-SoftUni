int number = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i <= number; i++)
{
	for (int y = 0; y <= number; y++)
	{
		for (int z = 0; z <= number; z++)
		{
			if (i + y + z == number)
			{
				count++;
			}
		}
	}
}

Console.WriteLine(count);