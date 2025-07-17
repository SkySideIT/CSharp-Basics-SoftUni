// 05.Supplies for School

int packofPens = int.Parse(Console.ReadLine());
int packofMarkers =  int.Parse(Console.ReadLine());
int litres = int.Parse(Console.ReadLine());
double percentageDiscount = double.Parse(Console.ReadLine());

double sumofPens = packofPens * 5.80;
double sumofMarkers = packofMarkers * 7.20;
double sumofLitres = litres * 1.20;

double sum = (sumofPens + sumofMarkers + sumofLitres);
double price = sum - (sum * (percentageDiscount/100));
Console.WriteLine(price);