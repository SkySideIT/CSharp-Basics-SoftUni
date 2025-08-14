int days = int.Parse(Console.ReadLine());
int foodInKilos = int.Parse(Console.ReadLine());
double foodForFirst = double.Parse(Console.ReadLine());
double foodForSecond = double.Parse(Console.ReadLine());
double foodForThird = double.Parse(Console.ReadLine());

double first = days * foodForFirst;
double second = days * foodForSecond;
double third = days * foodForThird;
double totalFoodNeeded = first + second + third;

if (foodInKilos > totalFoodNeeded)
{
    Console.WriteLine($"{Math.Floor(foodInKilos - totalFoodNeeded)} kilos of food left.");
}
else
{
    Console.WriteLine($"{Math.Ceiling(totalFoodNeeded - foodInKilos)} more kilos of food are needed.");
}