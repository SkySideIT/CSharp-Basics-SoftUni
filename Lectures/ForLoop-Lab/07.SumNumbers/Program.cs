using System.Diagnostics.CodeAnalysis;

int nums = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 0; i < nums; i++)
{
    int numN = int.Parse(Console.ReadLine());
    sum += numN;
}
Console.WriteLine(sum);