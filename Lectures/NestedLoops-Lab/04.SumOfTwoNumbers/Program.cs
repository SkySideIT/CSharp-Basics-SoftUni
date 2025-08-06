int start = int.Parse(Console.ReadLine());
int end  = int.Parse(Console.ReadLine());
int target = int.Parse(Console.ReadLine());

bool sumIsFound = false;
int count = 0;

for (int i = start; i <= end; i++)
{
    for (int y = start; y <= end; y++)
    {
        count++;
        if (i + y == target)
        {
            Console.WriteLine($"Combination N:{count} ({i} + {y} = {target})");
            sumIsFound = true;
            break;
        }
    }

    if (sumIsFound)
    {
        break;
    }
}

if (!sumIsFound)
{
    Console.WriteLine($"{count} combinations - neither equals {target}");
}