int num = int.Parse(Console.ReadLine());

for (int i = 0, power = 1; i <= num; i += 2, power*=4)
{
    Console.WriteLine(power);
}