// 09. Fish Tank

int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double volume = length * width * height;
double volumeInLitres = volume / 1000;
double neededLitres = volumeInLitres * (1 - (percentage/100));
Console.WriteLine(neededLitres);