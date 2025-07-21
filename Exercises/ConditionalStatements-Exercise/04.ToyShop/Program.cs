double puzzle = 2.60;
double doll = 3;
double bear = 4.10;
double minion = 8.20;
double truck = 2;

double price = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double sumPrice = (puzzle * puzzles) + (doll * dolls) + (bear * bears) + (minion * minions) + (truck * trucks);
int sumToys = puzzles + dolls + bears + minions + trucks;
if (sumToys >= 50)
{
    sumPrice = sumPrice * 0.75;
}
double rentDiscount = sumPrice * 0.1;
double gain = sumPrice - rentDiscount;
if (gain >= price)
{
    Console.WriteLine($"Yes! {(gain - price):f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {(price - gain):f2} lv needed.");
}