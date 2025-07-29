int groups = int.Parse(Console.ReadLine());
double sum = 0;
double musala = 0;
double monblan = 0;
double kili = 0;
double k2 = 0;
double everest = 0;
for (int i = 0; i < groups; i++)
{
    double num = double.Parse((Console.ReadLine()));
    sum += num;
    if (num <= 5)
    {
        musala+=num;
    }
    else if (num > 5 && num <= 12)
    {
        monblan+=num;
    }
    else if (num > 12 && num <= 25)
    {
        kili+=num;
    }
    else if (num > 25 && num <= 40)
    {
        k2+=num;
    }
    else if (num >= 41)
    {
        everest+=num;
    }
}

Console.WriteLine($"{((musala / sum) * 100):f2}%");
Console.WriteLine($"{((monblan / sum) * 100):f2}%");
Console.WriteLine($"{((kili / sum) * 100):f2}%");
Console.WriteLine($"{((k2 / sum) * 100):f2}%");
Console.WriteLine($"{((everest / sum) * 100):f2}%");