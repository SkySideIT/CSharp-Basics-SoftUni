﻿int n = int.Parse(Console.ReadLine());

double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 200)
    {
        p1++;
    }
    else if (num >= 200 && num < 400)
    {
        p2++;
    }
    else if (num >= 400 && num < 600)
    {
        p3++;
    }
    else if (num >= 600 && num < 800)
    {
        p4++;
    }
    else if (num >= 800)
    {
        p5++;
    }
}

Console.WriteLine($"{((p1 / n) * 100):f2}%");
Console.WriteLine($"{((p2 / n) * 100):f2}%");
Console.WriteLine($"{((p3 / n) * 100):f2}%");
Console.WriteLine($"{((p4 / n) * 100):f2}%");
Console.WriteLine($"{((p5 / n) * 100):f2}%");