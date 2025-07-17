// 07. Food Delivery

int chickenMenuCOunt = int.Parse(Console.ReadLine());
int fishMenuCount = int.Parse(Console.ReadLine());
int vegetarianMenuCount =  int.Parse(Console.ReadLine());

double sumMenu = chickenMenuCOunt * 10.35 + fishMenuCount * 12.40 + vegetarianMenuCount * 8.15;
double cakeSum = sumMenu * 0.2;
double sum = sumMenu + cakeSum + 2.50;
Console.WriteLine(sum);