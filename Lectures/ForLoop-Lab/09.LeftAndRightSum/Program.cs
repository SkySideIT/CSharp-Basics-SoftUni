int times = int.Parse(Console.ReadLine());

int leftSum =0;
for (int i = 0; i < times; i++)
{
    int num = int.Parse(Console.ReadLine());
    leftSum += num;
}

int rightSum =0;
for(int i = 0;i < times; i++)
{
    int num = int.Parse(Console.ReadLine());
    rightSum += num;
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
}