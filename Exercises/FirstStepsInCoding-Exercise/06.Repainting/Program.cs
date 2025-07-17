// 06. Repainting

int nailon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int razreditel = int.Parse(Console.ReadLine());
int neededHours = int.Parse(Console.ReadLine());

double nailonSum = (nailon + 2) * 1.50;
double paintSum = (paint * 1.10) * 14.50;
double razreditelSum = razreditel * 5;
double bagsSum = 0.40;

double materialSum = nailonSum + paintSum + razreditelSum + bagsSum;
double workSum = (materialSum * 0.30) * neededHours;

double result = materialSum + workSum;
Console.WriteLine(result);