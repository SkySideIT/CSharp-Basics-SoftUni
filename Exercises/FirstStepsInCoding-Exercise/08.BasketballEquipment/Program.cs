// 08. Basketball Equipment

int tax = int.Parse(Console.ReadLine());
double shoes = tax * 0.60;
double jersey = shoes * 0.80;
double ball = jersey * 0.25;
double accesories = ball * 0.20;
double result = tax + (shoes + jersey + ball + accesories);
Console.WriteLine(result);